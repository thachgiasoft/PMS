﻿<%@ Control Language="C#" ClassName="LoaiNhanVienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHrmid" runat="server" Text="Hrmid:" AssociatedControlID="dataHrmid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHrmid" Value='<%# Bind("Hrmid") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiNhanVien" runat="server" Text="Ten Loai Nhan Vien:" AssociatedControlID="dataTenLoaiNhanVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiNhanVien" Text='<%# Bind("TenLoaiNhanVien") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


