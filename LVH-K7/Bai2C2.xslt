<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/">
    <html>
      <head>
        <title>

        </title>
      </head>
      <body>
       <!--<xsl:call-templates  select="//lophoc[@malop='L101']"/>-->
        <xsl:for-each select="//lophoc[@malop='L101']">
          <xsl:call-template name="lophoc"/>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
  <xsl:template name="lophoc">
    <h1>
      <xsl:value-of select="tenlop"/>
    </h1>
  </xsl:template>    

   
</xsl:stylesheet>
