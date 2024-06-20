import threading
import time
import os
from selenium import webdriver
from selenium.webdriver.edge.service import Service as EdgeService
from selenium.webdriver.edge.options import Options
from selenium.webdriver.common.by import By
from webdriver_manager.microsoft import EdgeChromiumDriverManager

class Global:
    remoteConfigs = None

class RemoteConfig:
    def __init__(self,send, messageArea, banArea, footerArea,
                 attachment, numberNotFound, defaultSleep):
        self.send = send
        self.messageArea = messageArea
        self.banArea = banArea
        self.footerArea = footerArea
        self.attachment = attachment
        self.numberNotFound = numberNotFound
        self.defaultSleep = defaultSleep

Global.remoteConfigs = RemoteConfig(
    send="//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button",
    messageArea="//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div/p",
    banArea="#main > footer > div",
    footerArea="#main > footer",
    attachment="//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div/div/div/div/span",
    numberNotFound="#app > div > span:nth-child(2) > div > span > div > div > div > div > div > div > div > button > div > div",
    defaultSleep=3
)

class WhatsAppMaster:
    def __init__(self):
        self.webDriver = None
        self.scheme = "https://web.whatsapp.com/send?phone={0}&text={1}"
        self.unSentNumbers = []
        self.listNumbers = []
        self.listMessages = []
        self.sentIndex = 0
        self.initialize_selenium()

    def initialize_selenium(self):
        options = Options()
        options.add_argument("--user-data-dir=" + os.path.join(os.getcwd(), "BrowserData"))
        options.add_argument("userDataFolder=" + os.path.join(os.getcwd(), "BrowserData"))
        options.add_argument("disable-infobars")
        options.add_argument("--disable-logging")
        options.add_argument("--disable-extensions")
        options.add_argument("--no-sandbox")
        options.add_argument("--disable-dev-shm-usage")
        options.add_argument("--log-level=3")
        service = EdgeService(EdgeChromiumDriverManager().install())
        self.webDriver = webdriver.Edge(service=service, options=options)
        self.webDriver.minimize_window()

    def close_all_driver_processes(self):
        if self.webDriver:
            self.webDriver.close()
            self.webDriver.quit()
            self.webDriver = None
        for proc in os.popen('tasklist').read().strip().split('\n'):
            if 'msedgedriver' in proc:
                os.system('taskkill /f /im msedgedriver.exe')

    def force_send(self):
        for i in range(len(self.listNumbers)):
            time.sleep(Global.remoteConfigs.defaultSleep)
            self.load_next_url()

            elementFooterArea = None
            elementBanArea = None
            elementNumberNotFound = None

            while not elementFooterArea:
                try:
                    elementFooterArea = self.webDriver.find_element(By.CSS_SELECTOR, Global.remoteConfigs.footerArea)
                    elementBanArea = self.webDriver.find_element(By.CSS_SELECTOR, Global.remoteConfigs.banArea)
                    if elementBanArea and ("gönderemezsiniz" in elementBanArea.text or "blocked" in elementBanArea.text):
                        self.unSentNumbers.append(self.listNumbers[self.sentIndex])
                        break
                except Exception:
                    try:
                        elementNumberNotFound = self.webDriver.find_element(By.CSS_SELECTOR, Global.remoteConfigs.numberNotFound)
                        if elementNumberNotFound and elementNumberNotFound.is_displayed() and elementNumberNotFound.text.lower() == "okay":
                            self.unSentNumbers.append(self.listNumbers[self.sentIndex])
                            break
                    except Exception:
                        pass

            elementMessageArea = None
            while not elementMessageArea:
                try:
                    elementMessageArea = self.webDriver.find_element(By.XPATH, Global.remoteConfigs.messageArea)
                except Exception:
                    pass

            elementMessageSendButton = None
            while not elementMessageSendButton:
                try:
                    elementMessageSendButton = self.webDriver.find_element(By.XPATH, Global.remoteConfigs.send)
                except Exception:
                    pass

            while not elementMessageSendButton.is_displayed() or not elementMessageSendButton.is_enabled():
                time.sleep(Global.remoteConfigs.defaultSleep)

            elementMessageSendButton.click()

            self.sentIndex += 1
        time.sleep(Global.remoteConfigs.defaultSleep)
        self.finished()

    def finished(self):
        self.sentIndex = 0
        self.webDriver.minimize_window()
        print("Message Sending Completed")
        self.listNumbers.clear()
        self.listMessages.clear()
        if len(self.unSentNumbers) > 0:
            print("There are numbers that could'nt be able to send: ")
            print(self.unSentNumbers)
        self.unSentNumbers.clear()

    def load_next_url(self):
        number = self.listNumbers[self.sentIndex].strip().replace(" ", "")
        if len(number) == 11:
            number = "9" + number
        elif len(number) == 10:
            number = "90" + number
        elif len(number) != 12:
            print(f"Number: {number} is not valid. Skipping")
            self.unSentNumbers.append(number)
            self.sentIndex += 1
            self.load_next_url()
            return self
        self.webDriver.get(self.scheme.format(number, self.listMessages[self.sentIndex].replace("\n", "%0a")))

    def start_sending(self):
        threading.Thread(target=self.force_send).start()

if __name__ == "__main__":
    app = WhatsAppMaster()
    app.listNumbers = ["+90531blablalba"]
    app.listMessages = ["Test"]
    app.start_sending()

