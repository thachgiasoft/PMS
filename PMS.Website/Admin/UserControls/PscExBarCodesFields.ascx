<%@ Control Language="C#" ClassName="PscExBarCodesFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayGiao" runat="server" Text="Ngay Giao:" AssociatedControlID="dataNgayGiao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayGiao" Text='<%# Bind("NgayGiao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayGiao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiGiao" runat="server" Text="Nguoi Giao:" AssociatedControlID="dataNguoiGiao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiGiao" Text='<%# Bind("NguoiGiao") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayNhan" runat="server" Text="Ngay Nhan:" AssociatedControlID="dataNgayNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayNhan" Text='<%# Bind("NgayNhan", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayNhan" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiNhan" runat="server" Text="Nguoi Nhan:" AssociatedControlID="dataNguoiNhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiNhan" Text='<%# Bind("NguoiNhan") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaGuiMailNhacGiaoBai" runat="server" Text="Da Gui Mail Nhac Giao Bai:" AssociatedControlID="dataDaGuiMailNhacGiaoBai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaGuiMailNhacGiaoBai" SelectedValue='<%# Bind("DaGuiMailNhacGiaoBai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoBai" runat="server" Text="So Bai:" AssociatedControlID="dataSoBai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoBai" Text='<%# Bind("SoBai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoBai" runat="server" Display="Dynamic" ControlToValidate="dataSoBai" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTo" runat="server" Text="So To:" AssociatedControlID="dataSoTo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTo" Text='<%# Bind("SoTo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTo" runat="server" Display="Dynamic" ControlToValidate="dataSoTo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaGuiMailNhacThuHoiBai" runat="server" Text="Da Gui Mail Nhac Thu Hoi Bai:" AssociatedControlID="dataDaGuiMailNhacThuHoiBai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaGuiMailNhacThuHoiBai" SelectedValue='<%# Bind("DaGuiMailNhacThuHoiBai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaGuiMailNhacNhanBai" runat="server" Text="Da Gui Mail Nhac Nhan Bai:" AssociatedControlID="dataDaGuiMailNhacNhanBai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaGuiMailNhacNhanBai" SelectedValue='<%# Bind("DaGuiMailNhacNhanBai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateStaff" runat="server" Text="Update Staff:" AssociatedControlID="dataUpdateStaff" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateStaff" Text='<%# Bind("UpdateStaff") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataLanThi" runat="server" Display="Dynamic" ControlToValidate="dataLanThi" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataLanThi" runat="server" Display="Dynamic" ControlToValidate="dataLanThi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBarCode" runat="server" Text="Bar Code:" AssociatedControlID="dataBarCode" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBarCode" Text='<%# Bind("BarCode") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataBarCode" runat="server" Display="Dynamic" ControlToValidate="dataBarCode" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataKyThi" runat="server" Display="Dynamic" ControlToValidate="dataKyThi" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhanDang" runat="server" Text="Ma Nhan Dang:" AssociatedControlID="dataMaNhanDang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhanDang" Text='<%# Bind("MaNhanDang") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateDate" runat="server" Text="Update Date:" AssociatedControlID="dataUpdateDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateDate" Text='<%# Bind("UpdateDate", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataUpdateDate" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiaoBai" runat="server" Text="Giao Bai:" AssociatedControlID="dataGiaoBai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataGiaoBai" SelectedValue='<%# Bind("GiaoBai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhanBai" runat="server" Text="Nhan Bai:" AssociatedControlID="dataNhanBai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataNhanBai" SelectedValue='<%# Bind("NhanBai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


