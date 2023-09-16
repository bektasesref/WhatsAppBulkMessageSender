# WhatsAppBulkMessageSender
WhatsApp bulk message sender with Selenium WebDriver built on Visual Studio C# Form Application

Kinda commercial-like WhatsApp Message Sender. It uses https://web.whatsapp.com/send?phone=[replace] scheme to naviagte Selenium Driver.

To run the program, you need to setup couple of things.

First things first;

1) Import database (Hosted_DB -> file.sql) to your webserver
2) Transfer all files in Hosted_PHP folder directly to your webserver
3) If you want simple license (day check) system, change DaysLeftCronJob.php's database credentials which match yours. Add cronjob php file's url to your CPanel/CwpPanel etc. Configure it that triggers over a day. (0 0 * * * php -q [path])
4) Configure your WhatsappMasterJSON.json file. Especially authCheckURL field is important
5) Write your DB credentials to WhatsAppRegistrar.php file too
6) Open Visual Studio Solution, go to Resources. Configure remoteConfigURL field to you webserver's url of WhatsappMasterJSON.json file. It should be something like; https://www.esrefbektas.com/WhatsappMasterJSON.json


DB table should look like this:
![image](https://github.com/bektasesref/WhatsAppBulkMessageSender/assets/23198585/a7721f6f-be4e-4c20-8e41-7bbf978746bf)

Auth Screen:
![image](https://github.com/bektasesref/WhatsAppBulkMessageSender/assets/23198585/6913cc6c-6284-45a5-8731-2631e387e3ed)

Flow Video:
https://github.com/bektasesref/WhatsAppBulkMessageSender/assets/23198585/46c6ea8c-0641-46db-9231-c89a8b7403cd

