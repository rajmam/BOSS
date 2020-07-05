<%@ Page Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_addservice.aspx.cs" Inherits="admin_addservice" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 555px">
        <tr>
            <td style="width: 112px">
            </td>
            <td style="width: 131px">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            </td>
            <td style="width: 128px">
            </td>
        </tr>
    </table>
    <table style="width: 509px">
        <tr>
            <td style="width: 162px">
                <asp:Label ID="Label1" runat="server" Text="day"></asp:Label></td>
            <td style="width: 163px">
                <asp:DropDownList ID="ddlday" runat="server" BackColor="#FFFFC0" ForeColor="#C00000"
                    Width="155px" OnSelectedIndexChanged="ddlday_SelectedIndexChanged" >
                    <asp:ListItem Selected="True" Value="monday">monday</asp:ListItem>
                    <asp:ListItem Value="tuesday">tuesday</asp:ListItem>
                    <asp:ListItem Value="wednesday">wednesday</asp:ListItem>
                    <asp:ListItem Value="thursday">thursday</asp:ListItem>
                    <asp:ListItem Value="friday">friday</asp:ListItem>
                    <asp:ListItem Value="saturday">saturday</asp:ListItem>
                    <asp:ListItem Value="sunday">sunday</asp:ListItem>
                </asp:DropDownList></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 26px;">
                <asp:Label ID="Label2" runat="server" Text="bus no"></asp:Label></td>
            <td style="width: 163px; height: 26px;">
                <asp:TextBox ID="txtregno" runat="server" Width="155px"></asp:TextBox></td>
            <td style="height: 26px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 26px">
                <asp:Label ID="Label3" runat="server" Text="category"></asp:Label></td>
            <td style="width: 163px; height: 26px">
                <asp:DropDownList ID="ddlcategory" runat="server" Width="155px">
                    <asp:ListItem Value="Ordinary" Selected="True">ordinary</asp:ListItem>
                    <asp:ListItem Value="Limited Stop">limited stop</asp:ListItem>
                    <asp:ListItem Value="Fast Passenger">fast passenger</asp:ListItem>
                    <asp:ListItem Value="Ls Fp">Ls Fp</asp:ListItem>
                    <asp:ListItem Value="Town To Town">town to town</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 26px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 21px">
                <asp:Label ID="Label4" runat="server" Text="trip no"></asp:Label></td>
            <td style="width: 163px; height: 21px">
                <asp:TextBox ID="txttripno" runat="server" Width="37px"></asp:TextBox></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 26px;">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="From"></asp:Label></td>
            <td style="width: 163px; height: 26px;">
                <asp:TextBox ID="txtfrom" runat="server" Width="239px"></asp:TextBox></td>
            <td style="height: 26px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 21px">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="To"></asp:Label></td>
            <td style="width: 163px; height: 21px">
                <asp:TextBox ID="txtto" runat="server" Width="239px"></asp:TextBox></td>
            <td style="height: 21px">
                </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 21px">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Towards"></asp:Label></td>
            <td style="width: 163px; height: 21px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td style="height: 21px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 4px">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Time"></asp:Label></td>
            <td style="width: 163px; height: 4px">
                <table style="width: 248px">
                    <tr>
                        <td style="width: 77px">
                            &nbsp;<asp:DropDownList ID="DD1" runat="server" Width="40px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem Selected="True">00</asp:ListItem>
                </asp:DropDownList><asp:Label ID="Label7" runat="server" Height="20px" Text="hrs" Width="22px"></asp:Label></td>
                        <td style="width: 84px">
                            &nbsp;<asp:DropDownList ID="DD2" runat="server" Width="39px">
                    <asp:ListItem Selected="True">00</asp:ListItem>
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                    <asp:ListItem>35</asp:ListItem>
                    <asp:ListItem>36</asp:ListItem>
                    <asp:ListItem>37</asp:ListItem>
                    <asp:ListItem>38</asp:ListItem>
                    <asp:ListItem>39</asp:ListItem>
                    <asp:ListItem>40</asp:ListItem>
                    <asp:ListItem>41</asp:ListItem>
                    <asp:ListItem>42</asp:ListItem>
                    <asp:ListItem>43</asp:ListItem>
                    <asp:ListItem>45</asp:ListItem>
                    <asp:ListItem>46</asp:ListItem>
                    <asp:ListItem>47</asp:ListItem>
                    <asp:ListItem>48</asp:ListItem>
                    <asp:ListItem>49</asp:ListItem>
                    <asp:ListItem>50</asp:ListItem>
                    <asp:ListItem>51</asp:ListItem>
                    <asp:ListItem>52</asp:ListItem>
                    <asp:ListItem>53</asp:ListItem>
                    <asp:ListItem>54</asp:ListItem>
                    <asp:ListItem>55</asp:ListItem>
                    <asp:ListItem>56</asp:ListItem>
                    <asp:ListItem>57</asp:ListItem>
                    <asp:ListItem>58</asp:ListItem>
                    <asp:ListItem>59</asp:ListItem>
                </asp:DropDownList><asp:Label ID="Label9" runat="server" Height="20px"
                    Text="mnts" Width="33px"></asp:Label></td>
                        <td style="width: 3px">
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlapm" runat="server" Height="46px" Width="47px" OnSelectedIndexChanged="ddlapm_SelectedIndexChanged" >
                    <asp:ListItem Value="AM" Selected="True">AM</asp:ListItem>
                    <asp:ListItem Value="PM">PM</asp:ListItem>
                </asp:DropDownList></td>
                    </tr>
                </table>
                &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            </td>
            <td style="height: 4px">
            </td>
        </tr>
        <tr>
            <td style="width: 162px; height: 21px">
            </td>
            <td style="width: 163px; height: 21px">
                &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;<table style="width: 248px">
                    <tr>
                        <td style="width: 72px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="52px" /></td>
                        <td style="width: 83px">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="53px" /></td>
                        <td>
                        </td>
                    </tr>
                </table>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp;
            </td>
            <td style="height: 21px">
            </td>
        </tr>
    </table>
</asp:Content>

