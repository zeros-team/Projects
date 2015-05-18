<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                exclude-result-prefixes="msxsl"
>
<xsl:output method="xml" indent="yes" encoding="utf-8"/>
  <xsl:template match="/">
   
    <xsl:element name="DANHSACH">
      <xsl:text>DANH SÁCH SINH VIÊN</xsl:text>
      <xsl:for-each select="QLDIEM/hocsinh">
        <xsl:element name="sinhvien">
          <xsl:attribute name="masv">
            <xsl:value-of select="@mahs"/>
          </xsl:attribute>
          
          <xsl:element name="HOTEN">
            <xsl:value-of select="hoten"/>
          </xsl:element>
        </xsl:element>
      </xsl:for-each>
    </xsl:element>
  </xsl:template>
   
</xsl:stylesheet>
