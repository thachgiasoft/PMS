<%@ Control Language="C#" ClassName="QuyDoiHoatDongNgoaiGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTien" runat="server" Text="So Tien:" AssociatedControlID="dataSoTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTien" Text='<%# Bind("SoTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTien" runat="server" Display="Dynamic" ControlToValidate="dataSoTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietQuyDoi" runat="server" Text="So Tiet Quy Doi:" AssociatedControlID="dataSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietQuyDoi" Text='<%# Bind("SoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDongNgoaiGiangDay" runat="server" Text="Ma Hoat Dong Ngoai Giang Day:" AssociatedControlID="dataMaHoatDongNgoaiGiangDay" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHoatDongNgoaiGiangDay" DataSourceID="MaHoatDongNgoaiGiangDayGiangVienHoatDongNgoaiGiangDayDataSource" DataTextField="NamHoc" DataValueField="MaQuanLy" SelectedValue='<%# Bind("MaHoatDongNgoaiGiangDay") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:GiangVienHoatDongNgoaiGiangDayDataSource ID="MaHoatDongNgoaiGiangDayGiangVienHoatDongNgoaiGiangDayDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


