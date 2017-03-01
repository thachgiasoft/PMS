<%@ Control Language="C#" ClassName="ThuLaoRaDeThiVhuexFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataVanDap" runat="server" Text="Van Dap:" AssociatedControlID="dataVanDap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataVanDap" Text='<%# Bind("VanDap") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataVanDap" runat="server" Display="Dynamic" ControlToValidate="dataVanDap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThucHanh" runat="server" Text="Thuc Hanh:" AssociatedControlID="dataThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThucHanh" Text='<%# Bind("ThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataThucHanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuLuan" runat="server" Text="Tu Luan:" AssociatedControlID="dataTuLuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuLuan" Text='<%# Bind("TuLuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuLuan" runat="server" Display="Dynamic" ControlToValidate="dataTuLuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongHop" runat="server" Text="Tong Hop:" AssociatedControlID="dataTongHop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongHop" Text='<%# Bind("TongHop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongHop" runat="server" Display="Dynamic" ControlToValidate="dataTongHop" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateDate" runat="server" Text="Update Date:" AssociatedControlID="dataUpdateDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateDate" Text='<%# Bind("UpdateDate", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataUpdateDate" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateStaff" runat="server" Text="Update Staff:" AssociatedControlID="dataUpdateStaff" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateStaff" Text='<%# Bind("UpdateStaff") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTieuLuan" runat="server" Text="Tieu Luan:" AssociatedControlID="dataTieuLuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTieuLuan" Text='<%# Bind("TieuLuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTieuLuan" runat="server" Display="Dynamic" ControlToValidate="dataTieuLuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChuan" runat="server" Text="Gio Chuan:" AssociatedControlID="dataGioChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuan" Text='<%# Bind("GioChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuan" runat="server" Display="Dynamic" ControlToValidate="dataGioChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTracNghiemTren50" runat="server" Text="Trac Nghiem Tren50:" AssociatedControlID="dataTracNghiemTren50" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTracNghiemTren50" Text='<%# Bind("TracNghiemTren50") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTracNghiemTren50" runat="server" Display="Dynamic" ControlToValidate="dataTracNghiemTren50" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLanThi" runat="server" Display="Dynamic" ControlToValidate="dataLanThi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThi" runat="server" Text="Dot Thi:" AssociatedControlID="dataDotThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThi" Text='<%# Bind("DotThi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTracNghiemDuoi50" runat="server" Text="Trac Nghiem Duoi50:" AssociatedControlID="dataTracNghiemDuoi50" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTracNghiemDuoi50" Text='<%# Bind("TracNghiemDuoi50") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTracNghiemDuoi50" runat="server" Display="Dynamic" ControlToValidate="dataTracNghiemDuoi50" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThanhToan" runat="server" Text="Dot Thanh Toan:" AssociatedControlID="dataDotThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThanhToan" Text='<%# Bind("DotThanhToan") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGv" runat="server" Text="Ma Gv:" AssociatedControlID="dataMaGv" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGv" Text='<%# Bind("MaGv") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


