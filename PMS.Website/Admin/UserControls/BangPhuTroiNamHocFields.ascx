<%@ Control Language="C#" ClassName="BangPhuTroiNamHocFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoiHuongDanGvTinhNguyen" runat="server" Text="Tiet Quy Doi Huong Dan Gv Tinh Nguyen:" AssociatedControlID="dataTietQuyDoiHuongDanGvTinhNguyen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoiHuongDanGvTinhNguyen" Text='<%# Bind("TietQuyDoiHuongDanGvTinhNguyen") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoiHuongDanGvTinhNguyen" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoiHuongDanGvTinhNguyen" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaGiangVien" DataSourceID="MaGiangVienGiangVienDataSource" DataTextField="MaDanToc" DataValueField="MaGiangVien" SelectedValue='<%# Bind("MaGiangVien") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:GiangVienDataSource ID="MaGiangVienGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNckhTrungCap" runat="server" Text="So Tiet Nckh Trung Cap:" AssociatedControlID="dataSoTietNckhTrungCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNckhTrungCap" Text='<%# Bind("SoTietNckhTrungCap") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNckhTrungCap" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNckhTrungCap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNckhCaoDang" runat="server" Text="So Tiet Nckh Cao Dang:" AssociatedControlID="dataSoTietNckhCaoDang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNckhCaoDang" Text='<%# Bind("SoTietNckhCaoDang") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNckhCaoDang" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNckhCaoDang" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioThiHk1" runat="server" Text="Gio Thi Hk1:" AssociatedControlID="dataGioThiHk1" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioThiHk1" Text='<%# Bind("GioThiHk1") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioThiHk1" runat="server" Display="Dynamic" ControlToValidate="dataGioThiHk1" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioThiHk2" runat="server" Text="Gio Thi Hk2:" AssociatedControlID="dataGioThiHk2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioThiHk2" Text='<%# Bind("GioThiHk2") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioThiHk2" runat="server" Display="Dynamic" ControlToValidate="dataGioThiHk2" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


