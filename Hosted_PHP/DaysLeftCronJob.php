<?php
$servername = "localhost";
$dbUsername = "wpmaster_db";
$dbPassword = "U3F77{corrupted]aASD2";
$dbname = "esref_what[replace_with_your]essage";

$connection = new mysqli($servername, $dbUsername, $dbPassword, $dbname);

$sql = "UPDATE auths SET daysLeft=daysLeft-1";
$stmt= $connection->prepare($sql);
$stmt->execute();

$connection->close();
?>