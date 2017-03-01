<%@ Control Language="C#" ClassName="HeSoTinChiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHeDaoTao" runat="server" Text="Ma He Dao Tao:" AssociatedControlID="dataMaHeDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHeDaoTao" Text='<%# Bind("MaHeDaoTao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaHeDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataMaHeDaoTao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataMaBacDaoTao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTinChi" runat="server" Text="He So Tin Chi:" AssociatedControlID="dataHeSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTinChi" Text='<%# Bind("HeSoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


