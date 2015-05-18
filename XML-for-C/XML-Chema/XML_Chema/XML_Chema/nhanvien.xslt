﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="congty">
      <html>
        <body>
          <h1 align="center" style="color:red">BẢNG LƯƠNG THÁNG 11-2013</h1>
          <xsl:for-each select="donvi">
            <h2>
              Mã đơn vị: <xsl:value-of select="madv"/>
            </h2>
            <h2>
              Tên đơn vị: <xsl:value-of select="tendv"/>
            </h2>
            <h2>
              Điện thoại: <xsl:value-of select="dienthoai"/>
            </h2>
          </xsl:for-each><!--Vòng lặp lấy dữ liệu từ donvi-->
          <h1 align="center"  style="color:green">DANH SÁCH NHÂN VIÊN</h1>
          <table align="center" border="2" cellspacing="0">
            <tr align="center">
              <td>SỐ TT</td>
              <td>Mã NV</td>
              <td>HỌ TÊN</td>
              <td>NGÀY SINH</td>
              <td>HS LƯƠNG</td>
              <td>LƯƠNG</td>
            </tr>
            <!--Vòng lặp lấy dữ liệu từ nút nhanvien-->
            <xsl:for-each select="nhanvien">
              <xsl:variable name="hsluong" select="hsluong" />
              <xsl:if test="hsluong >= 3">
                <tr align="center">
                  <td>
                    <xsl:value-of select="position()"/>
                  </td>
                  <td>
                    <xsl:value-of select="manv"/>
                  </td>
                  <td>
                    <xsl:value-of select="hoten"/>
                  </td>
                  <td>
                    <xsl:value-of select="ngaysinh"/>
                  </td>
                  <td>
                    <xsl:value-of select="hsluong"/>
                  </td>
                  <td>
                    <xsl:value-of select="hsluong*103000"/>
                  </td>
                </tr>
              </xsl:if>
            </xsl:for-each>
          </table>
          <h3 align="right">THỦ TRƯỞNG ĐƠN VỊ</h3>
        </body>
      </html>
    </xsl:template>
</xsl:stylesheet>
