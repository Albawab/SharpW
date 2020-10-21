<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet  version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">

<html>
<body>
	<h1 style="color:red;">Specimens I have found: </h1>
	<table style="width:50%">
		<tr bgcolor="#9acd32">
           <th style="text-align:left">Title</th>
           <th style="text-align:left">Artist</th>
		</tr>
    <xsl:for-each select="catalog/cd">
    <tr>
        <td><xsl:value-of select="title"/></td>
        <td><xsl:value-of select="artist"/></td>
    </tr>
    </xsl:for-each>
	</table>
</body>
</html>

</xsl:template>
</xsl:stylesheet >