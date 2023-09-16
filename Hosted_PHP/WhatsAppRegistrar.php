<?php
$servername = "localhost";
$dbUsername = "wpmaster_db";
$dbPassword = "U3F77{corrupted]aASD2";
$dbname = "esref_what[replace_with_your]essage";

$connection = new mysqli($servername, $dbUsername, $dbPassword, $dbname);

if(isset($_POST['username']) && isset($_POST['password']) && isset($_POST['deviceID']) && isset($_POST['version']))
{    
    $username = $_POST['username'];
    $password = $_POST['password'];
    $deviceID = $_POST['deviceID'];
	$query = mysqli_query($connection, "SELECT * FROM auths WHERE username='$username' AND password='$password'");
	
	if (mysqli_num_rows($query) == 0)
		echo "Invalid User";
	else
	{
		while($row = $query->fetch_assoc()) 
		{
			$deviceIDAtDB = $row["deviceID"];
			if ($deviceIDAtDB == "")
			{
				$queryUpdate = mysqli_query($connection, "UPDATE auths SET deviceID = '$deviceID' WHERE username='$username' AND password='$password'");
				$deviceIDAtDB =  $deviceID;
			}
			
			if ($deviceIDAtDB != $deviceID)
				echo "Already Linked";
			else
				echo $row["daysLeft"];
		}
	}
	
}
else if(isset($_GET['username']) && isset($_GET['password']) && isset($_GET['deviceID']) && isset($_GET['version'])) // for test it from url
{
    $username = $_GET['username'];
    $password = $_GET['password'];
    $deviceID = $_GET['deviceID'];
	$query = mysqli_query($connection, "SELECT * FROM auths WHERE username='$username' AND password='$password'");
	
	if (mysqli_num_rows($query) == 0)
		echo "Invalid User";
	else
	{
		while($row = $query->fetch_assoc()) 
		{
			$deviceIDAtDB = $row["deviceID"];
			if ($deviceIDAtDB == "")
			{
				$queryUpdate = mysqli_query($connection, "UPDATE auths SET deviceID = '$deviceID' WHERE username='$username' AND password='$password'");
				$deviceIDAtDB =  $deviceID;
			}
			
			if ($deviceIDAtDB != $deviceID)
				echo "Already Linked";
			else
				echo $row["daysLeft"];
		}
	}
}
	$connection->close();
?>