<%@ Control Language="C#" ClassName="ThuLaoCoiThiVhuexFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSafeName120Phut" runat="server" Text="Phut:" AssociatedControlID="dataSafeName120Phut" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSafeName120Phut" Text='<%# Bind("SafeName120Phut") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSafeName120Phut" runat="server" Display="Dynamic" ControlToValidate="dataSafeName120Phut" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSafeName90Phut" runat="server" Text="Phut:" AssociatedControlID="dataSafeName90Phut" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSafeName90Phut" Text='<%# Bind("SafeName90Phut") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSafeName90Phut" runat="server" Display="Dynamic" ControlToValidate="dataSafeName90Phut" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSafeName60Phut" runat="server" Text="Phut:" AssociatedControlID="dataSafeName60Phut" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSafeName60Phut" Text='<%# Bind("SafeName60Phut") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSafeName60Phut" runat="server" Display="Dynamic" ControlToValidate="dataSafeName60Phut" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoCa" runat="server" Text="So Ca:" AssociatedControlID="dataSoCa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoCa" Text='<%# Bind("SoCa") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoCa" runat="server" Display="Dynamic" ControlToValidate="dataSoCa" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateStaff" runat="server" Text="Update Staff:" AssociatedControlID="dataUpdateStaff" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateStaff" Text='<%# Bind("UpdateStaff") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateDate" runat="server" Text="Update Date:" AssociatedControlID="dataUpdateDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateDate" Text='<%# Bind("UpdateDate", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataUpdateDate" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioChuan" runat="server" Text="Gio Chuan:" AssociatedControlID="dataGioChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioChuan" Text='<%# Bind("GioChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioChuan" runat="server" Display="Dynamic" ControlToValidate="dataGioChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKyThi" runat="server" Text="Ky Thi:" AssociatedControlID="dataKyThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKyThi" Text='<%# Bind("KyThi") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanThi" runat="server" Text="Lan Thi:" AssociatedControlID="dataLanThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanThi" Text='<%# Bind("LanThi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLanThi" runat="server" Display="Dynamic" ControlToValidate="dataLanThi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThi" runat="server" Text="Dot Thi:" AssociatedControlID="dataDotThi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThi" Text='<%# Bind("DotThi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGv" runat="server" Text="Ma Gv:" AssociatedControlID="dataMaGv" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGv" Text='<%# Bind("MaGv") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThanhToan" runat="server" Text="Dot Thanh Toan:" AssociatedControlID="dataDotThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThanhToan" Text='<%# Bind("DotThanhToan") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


