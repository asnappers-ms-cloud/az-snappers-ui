<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="az_snappers_ui.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- Bootstrap CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/Home/Home.css" rel="stylesheet" />
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="headDiv" class="grid-container top-con">
                <div class="priceCell" style="vertical-align: bottom">
                    <span>Azure Snappers
                    </span>
                </div>
                <div style="text-align: right; vertical-align: bottom">
                    <span style="text-align: right; vertical-align: text-bottom">Morgan Stanley Digital Banking
                    </span>
                </div>

            </div>
            <div id="centralPage" class="centralPage">

                <div id="detailDiv" class="grid-container main-con">

                    <div>
                        <div>
                            <asp:Table ID="HeaderTable" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell CssClass="priceCell">
                                        <asp:Label ID="lblPrice" runat="server" Text="ABC"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell CssClass="tblCell">
                                        <asp:Label ID="lblBed" runat="server" Text="Bed"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell CssClass="tblCell">
                                        <asp:Label ID="lblBath" runat="server" Text="Bath"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell CssClass="tblCell">
                                        <asp:Label ID="lblSqFt" runat="server" Text="SqFt"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>


                        </asp:Table>
                        <asp:Table runat="server">
                            <asp:TableRow CssClass="addressCell">
                                <asp:TableCell CssClass="addressCell">
                                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table>
                            </asp:Table>
                            <asp:Table runat="server" id="tblAddress">
                                <asp:TableRow>
                                    <asp:TableCell CssClass="addressCell">
                                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>


                        </div>
                        <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
                            <div class="carousel-inner">
                                <asp:Repeater ID="rptGallery" runat="server">
                                    <ItemTemplate>
                                        <div class="carousel-item  <%# (Container.ItemIndex == 0? "active": "")%>">
                                            <img src="<%# Eval("Name").ToString() %>" class="d-block w-100" alt="..." />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Previous</span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>
                        </div>
                    </div>
                    <div>
                        <table>
                            <tr>
                                <td class="priceCell">
                                    <span>House Details
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Table ID="tblHouseDetails" runat="server">
                                    </asp:Table>
                                </td>
                            </tr>
                        </table>
                    </div>

                </div>

                <div id="bottomDiv" class="grid-container">
                    <div>
                        <span class="priceCell">Goal Based Planing
                        </span>
                    </div>
                    <div>
                        <span class="priceCell">Genome Insignts</span>
                    </div>

                </div>

            </div>

        </div>
        <script type="text/javascript">

            (function () {
                var div = document.createElement("div");
                document.getElementsByTagName('body')[0].appendChild(div);
                div.outerHTML = "<div id='botDiv' style='height: 38px; position: fixed; bottom: 0; z-index: 1000; background-color: orangered; right: 0;'><div id='botTitleBar' style='height: 38px; width: 400px; position:fixed; cursor: pointer; background-color: orangered;'></div><iframe width='400px' height='600px' src='https://webchat.botframework.com/embed/az-snapper-qnaservice-bot?s=lUZ5sl8_qpk.SdoZc13jeGQE37K0kQGF0gdyPK7UrECxgsEm2lFMxu8'></iframe></div>";

                document.querySelector('body').addEventListener('click', function (e) {
                    e.target.matches = e.target.matches || e.target.msMatchesSelector;
                    if (e.target.matches('#botTitleBar')) {
                        var botDiv = document.querySelector('#botDiv');
                        botDiv.style.height = botDiv.style.height == '600px' ? '38px' : '600px';
                    };
                });
            }());

        </script>
    </form>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
