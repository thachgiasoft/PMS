<%@ Control Language="C#" ClassName="SdhChotKhoiLuongGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhoiLuongKhac" runat="server" Text="Khoi Luong Khac:" AssociatedControlID="dataKhoiLuongKhac" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataKhoiLuongKhac" SelectedValue='<%# Bind("KhoiLuongKhac") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDoAnTotNghiep" runat="server" Text="Do An Tot Nghiep:" AssociatedControlID="dataDoAnTotNghiep" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDoAnTotNghiep" SelectedValue='<%# Bind("DoAnTotNghiep") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDot" runat="server" Text="Ma Dot:" AssociatedControlID="dataMaDot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDot" Text='<%# Bind("MaDot") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDoAnMonHoc" runat="server" Text="Do An Mon Hoc:" AssociatedControlID="dataDoAnMonHoc" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDoAnMonHoc" SelectedValue='<%# Bind("DoAnMonHoc") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLyThuyetThucHanh" runat="server" Text="Ly Thuyet Thuc Hanh:" AssociatedControlID="dataLyThuyetThucHanh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLyThuyetThucHanh" SelectedValue='<%# Bind("LyThuyetThucHanh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


