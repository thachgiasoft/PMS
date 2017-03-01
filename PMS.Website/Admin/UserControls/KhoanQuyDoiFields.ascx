<%@ Control Language="C#" ClassName="KhoanQuyDoiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuyDoi" runat="server" Text="Ma Quy Doi:" AssociatedControlID="dataMaQuyDoi" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaQuyDoi" DataSourceID="MaQuyDoiQuyDoiGioChuanDataSource" DataTextField="MaQuanLy" DataValueField="MaQuyDoi" SelectedValue='<%# Bind("MaQuyDoi") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:QuyDoiGioChuanDataSource ID="MaQuyDoiQuyDoiGioChuanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuKhoan" runat="server" Text="Tu Khoan:" AssociatedControlID="dataTuKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuKhoan" Text='<%# Bind("TuKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuKhoan" runat="server" Display="Dynamic" ControlToValidate="dataTuKhoan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDenKhoan" runat="server" Text="Den Khoan:" AssociatedControlID="dataDenKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenKhoan" Text='<%# Bind("DenKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDenKhoan" runat="server" Display="Dynamic" ControlToValidate="dataDenKhoan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuTu" runat="server" Text="Thu Tu:" AssociatedControlID="dataThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuTu" Text='<%# Bind("ThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuTu" runat="server" Display="Dynamic" ControlToValidate="dataThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


