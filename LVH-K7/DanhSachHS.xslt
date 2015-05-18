<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/QLDIEM">
      <html>
        <head></head>
        <body>
          <xsl:for-each select ="lop">
            <xsl:variable name="ml" select="@malop"/>
            <center>
              <H1>THÔNG TIN GIÁO VIÊN CHỦ NHIỆM</H1>
              <xsl:text>Lớp:</xsl:text>
              <xsl:value-of select="$ml"/>
               <TABLE BORDER="1">
                <tr>
                  <td>STT</td>
                  <td>Tên lớp</td>
                  <td>Giáo viên chủ nhiệm</td>
                </tr>
              <xsl:for-each select="following-sibling::lophoc[@malop=$ml]">
                <tr>
                  <td>
                    <xsl:value-of select="position()"/>
                  </td>
                  <td>
                    <xsl:value-of select="tenlop"/>
                  </td>

                  <td>
                    <xsl:value-of select="gvcn"/>
                  </td>
                

                </tr>
              </xsl:for-each>
              </TABLE>
            </center>
          </xsl:for-each>
          
        </body>
      </html>
       
    </xsl:template>
</xsl:stylesheet>
