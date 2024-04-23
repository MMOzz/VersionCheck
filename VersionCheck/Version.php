<?php
header('Content-Type: application/json');
$method = $_SERVER['REQUEST_METHOD'];
switch ($method) {
	case 'GET':
		$result = "7.12.345";
		echo json_encode($result);
	 break;
 default:
 http_response_code(405);
 break;
}
?>