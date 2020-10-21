<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet  version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">


   
    <xsl:template match="/">
    <html>
       <header>
           <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
       </header>
        <body>
          
          <h3>Variable:</h3> 
          <xsl:variable name="var1">
                 <xsl:copy-of select="class/student/name"></xsl:copy-of>
            </xsl:variable>
                  <xsl:value-of select="$var1"></xsl:value-of><br></br><br></br><br></br>
           
           
           <h3>Attrbuite XML</h3>
          <xsl:for-each select="class/student">
               <xsl:value-of select="@id" />
            </xsl:for-each><br></br><br></br>
            
			<h3>Zet value van attrbuite xml en value.</h3>
			  <xsl:for-each select="class/student"><br></br>
				  <xsl:value-of select="name"></xsl:value-of><br></br>
               <xsl:value-of select="@id" />
            </xsl:for-each><br></br><br></br>
					
           
           
            <h3>This is the teachers</h3>
            <table class="table">
               <thead class="thead-dark">
                <tr>
                    <th>Name</th>
                    <th>Phone</th>
                </tr>
                  </thead>
                  <tbody>
                <xsl:for-each select="class/teacher">
                <xsl:sort select="name"/>    
                  <xsl:if test="phone >1">
                <tr>
                    <td><xsl:value-of select="name"/></td>
                    <td><xsl:value-of select="phone"/></td>
                </tr>
                    </xsl:if>
                </xsl:for-each>
                </tbody>
            </table>
            
            <h3>This is the students</h3>
            <table class="table">
               <thead class="thead-dark">
                <tr>
                    <th>Name</th>
                    <th>Number</th>
                    <th>Phone</th>
                </tr>
                </thead>
                <tbody>
                <xsl:for-each select="class/student">

                <tr>
                    <td><xsl:value-of select="name"/></td>
                    <xsl:choose>
                    <xsl:when test="number > 1">
                              <td style="background:red;"><xsl:value-of select="number"/></td>
                    </xsl:when>
                    <xsl:otherwise>
                        <td><xsl:value-of select="number"/></td>
                    </xsl:otherwise>
                     </xsl:choose>
                    <td><xsl:value-of select="phone"/></td>
                </tr>

                </xsl:for-each>
                </tbody>
            </table>
        </body>
    </html>
    </xsl:template>
</xsl:stylesheet>