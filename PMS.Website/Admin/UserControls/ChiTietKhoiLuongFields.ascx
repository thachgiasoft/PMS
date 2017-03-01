<%@ Control Language="C#" ClassName="ChiTietKhoiLuongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoiLuong" runat="server" Text="Ma Khoi Luong:" AssociatedControlID="dataMaKhoiLuong" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaKhoiLuong" DataSourceID="MaKhoiLuongKhoiLuongKhacDataSource" DataTextField="LoaiHocPhan" DataValueField="MaKhoiLuong" SelectedValue='<%# Bind("MaKhoiLuong") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:KhoiLuongKhacDataSource ID="MaKhoiLuongKhoiLuongKhacDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaSinhVien" runat="server" Text="Ma Sinh Vien:" AssociatedControlID="dataMaSinhVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaSinhVien" Text='<%# Bind("MaSinhVien") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


