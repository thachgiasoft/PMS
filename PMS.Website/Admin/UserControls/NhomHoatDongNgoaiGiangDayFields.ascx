<%@ Control Language="C#" ClassName="NhomHoatDongNgoaiGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataOrderBy" runat="server" Text="Order By:" AssociatedControlID="dataOrderBy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataOrderBy" Text='<%# Bind("OrderBy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataOrderBy" runat="server" Display="Dynamic" ControlToValidate="dataOrderBy" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhom" runat="server" Text="Ma Nhom:" AssociatedControlID="dataMaNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhom" Text='<%# Bind("MaNhom") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaNhom" runat="server" Display="Dynamic" ControlToValidate="dataMaNhom" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNhom" runat="server" Text="Ten Nhom:" AssociatedControlID="dataTenNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNhom" Text='<%# Bind("TenNhom") %>' MaxLength="200"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTenNhom" runat="server" Display="Dynamic" ControlToValidate="dataTenNhom" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


