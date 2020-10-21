<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet  version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
    <html>
       <header>
           <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
       </header>
        <body>
			<div style="margin-left:15px">
				<h1 class="bg-danger">Aeolus Beheer</h1>

				<xsl:for-each select="doc/members/member">

					<h5><xsl:value-of select="@name"></xsl:value-of></h5>
					<div style="margin-left:15px;">
						<xsl:if test="summary != ''">
							<h6 style="color:green">Summary:</h6>
							<div style="margin-left:15px">
								<xsl:value-of select="summary/@name"></xsl:value-of>
								<xsl:value-of select="summary"></xsl:value-of>
							</div>
						</xsl:if>

						  <xsl:variable name='param'>
							 <xsl:value-of select="param"/>
						   </xsl:variable>
						   <p> 
							   <xsl:if test="$param != ''">
								   <h6 style="color:green">Params:</h6>
									<div style="margin-left:15px">
										 <xsl:for-each select="/doc/members/member[param=$param]">
											  <label style="color:blue;margin-right:10px"><xsl:value-of select="param/@name"/>: </label> 
											  <xsl:value-of select="param"/> <br/>
										 </xsl:for-each>
								   </div>
							  </xsl:if>
						   </p>

						<xsl:if test="returns != ''">
						<h6 style="color:green">Returns:</h6>
							<div style="margin-left:15px">
								<xsl:value-of select="returns/@name"></xsl:value-of>
								<xsl:value-of select="returns"></xsl:value-of>
							</div>
						</xsl:if>
						<hr/><hr/>
					</div>
				</xsl:for-each>
			</div>
        </body>
    </html>
    </xsl:template>
</xsl:stylesheet>

