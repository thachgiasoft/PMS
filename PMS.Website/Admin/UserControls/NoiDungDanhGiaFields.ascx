<%@ Control Language="C#" ClassName="NoiDungDanhGiaFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoThuTu" runat="server" Text="So Thu Tu:" AssociatedControlID="dataSoThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoThuTu" Text='<%# Bind("SoThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoThuTu" runat="server" Display="Dynamic" ControlToValidate="dataSoThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
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
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNoiDungDanhGia" runat="server" Text="Ten Noi Dung Danh Gia:" AssociatedControlID="dataTenNoiDungDanhGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNoiDungDanhGia" Text='<%# Bind("TenNoiDungDanhGia") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataVietTat" runat="server" Text="Viet Tat:" AssociatedControlID="dataVietTat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataVietTat" Text='<%# Bind("VietTat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


