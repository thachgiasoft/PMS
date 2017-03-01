<%@ Control Language="C#" ClassName="HoatDongNgoaiGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhom" runat="server" Text="Ma Nhom:" AssociatedControlID="dataMaNhom" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNhom" DataSourceID="MaNhomNhomHoatDongNgoaiGiangDayDataSource" DataTextField="TenNhom" DataValueField="MaNhom" SelectedValue='<%# Bind("MaNhom") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NhomHoatDongNgoaiGiangDayDataSource ID="MaNhomNhomHoatDongNgoaiGiangDayDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucQuyDoi" runat="server" Text="Muc Quy Doi:" AssociatedControlID="dataMucQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucQuyDoi" Text='<%# Bind("MucQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataMucQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHoatDong" runat="server" Text="Ten Hoat Dong:" AssociatedControlID="dataTenHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHoatDong" Text='<%# Bind("TenHoatDong") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonViTinh" runat="server" Text="Ma Don Vi Tinh:" AssociatedControlID="dataMaDonViTinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonViTinh" Text='<%# Bind("MaDonViTinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaDonViTinh" runat="server" Display="Dynamic" ControlToValidate="dataMaDonViTinh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuong" runat="server" Text="So Luong:" AssociatedControlID="dataSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuong" Text='<%# Bind("SoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


