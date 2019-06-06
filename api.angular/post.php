<?php
require_once("inc.config.php");

file_put_contents("post.log", print_r($_POST, true), FILE_APPEND);
#file_put_contents("post.log", file_get_contents("php://input"), FILE_APPEND);
#echo file_get_contents("php://input");

echo "posted";
