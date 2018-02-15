<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AcmeChallengeResponder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>Acme challenge responder</title>
</head>
<body>
  <div>
    <% Response.Write(Guid.NewGuid().ToString()); %>
  </div>
</body>
</html>