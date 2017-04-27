<?php
require_once("inc.config.php");

class purpose
{
	public function __construct(string $purpose, string $url)
	{
		$this->purpose = $purpose;
		$this->url = $url;
	}
}

/**
 * Every index in this JSON has to be a C# URL Node Object variable
 * @see Live Mode
 * @see Testing Mode
 * @see Dev mode
 */
$endpoints = [
	"login" => new purpose("login", "http://localhost/login"),
	"password" => new purpose("change password", "http://localhost/password/change"),
	"products" => new purpose("List of products", "http://localhost/products/list"),
	"gateway" => new purpose("List of products", "http://localhost/gateway"),
];

$json = json_encode($endpoints);
echo $json;

#print_r(json_decode($json, true));
