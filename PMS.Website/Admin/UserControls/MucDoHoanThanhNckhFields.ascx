<%@ Control Language="C#" ClassName="MucDoHoanThanhNckhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramDuocHuong" runat="server" Text="Phan Tram Duoc Huong:" AssociatedControlID="dataPhanTramDuocHuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramDuocHuong" Text='<%# Bind("PhanTramDuocHuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramDuocHuong" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramDuocHuong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMucDo" runat="server" Text="Ten Muc Do:" AssociatedControlID="dataTenMucDo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMucDo" Text='<%# Bind("TenMucDo") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


