<%@ Control Language="C#" ClassName="GiangVienGiamTruDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiamTru" runat="server" Text="Ma Giam Tru:" AssociatedControlID="dataMaGiamTru" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiamTru" DataSourceID="MaGiamTruGiamTruDinhMucDataSource" DataTextField="NoiDungGiamTru" DataValueField="MaQuanLy" SelectedValue='<%# Bind("MaGiamTru") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiamTruDinhMucDataSource ID="MaGiamTruGiamTruDinhMucDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramGiamTru" runat="server" Text="Phan Tram Giam Tru:" AssociatedControlID="dataPhanTramGiamTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramGiamTru" Text='<%# Bind("PhanTramGiamTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramGiamTru" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramGiamTru" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


