<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="Animalitos.Paginas.FAQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="FAQpage" ContentPlaceHolderID="cphPrincipal" runat="server">


    <p>
        Muchas preguntas pueden surgir acerca de esta pagina, y en esta trataremos de contestar a todas ellas.
    </p>
    <div align="left">
        <asp:TextBox runat="server" Text="¿Quíenes sómos?" BorderColor="White" BorderWidth="0" Font-Size="28" Font-Bold="True"></asp:TextBox>
    </div>
    <div align="left">
        <p>
            Somos un equipo de dos integrantes; Rigoberto Duarte Gonzalí y Angel Adael Romero Rivera. Entre los dos, un dia, tuvimos una vision. La de aprobar la materia de "Programacion Web" con la mejor calificacion posible. 
            Para eso nos pusimos manos a la obra, creamos un proyecto en GitHub, y, despues de muchos contratiempos, logramos fundar Animalitos™. 
        </p>
    </div>
    <div align="left">
        <asp:TextBox runat="server" Text="¿Por qué Animalitos?" BorderColor="White" BorderWidth="0" Font-Size="28" Font-Bold="True" Width="391px"></asp:TextBox>
    </div>
    <div align="left">
        <p>
            Este proyecto vio sus inicios en materias anteriores, en las cuales, cada integrante del actual equipo de Animalitos™ poseia un proyecto individual. No pasó mucho antes que decidieramos unir ambos proyectos y crear este equipo de trabajo con tanto futuro.
            Cabe destacar que ha sido un trabajo arduo y una jornada muy dura, pero aun así, estamos comprometidos con nuestro trabajo de conseguir una buena calificacion.
        </p>
    </div>
    <div align="left">
        <asp:TextBox runat="server" Text="¿No era Compra Venta de animalitos?" BorderColor="White" BorderWidth="0" Font-Size="28" Font-Bold="True" Width="696px"></asp:TextBox>
    </div>
    <div align="left">
        <p>
            No
        </p>
    </div>
    <div align="left">
        <asp:TextBox runat="server" Text="¿En serio apuntan a la maxima calificacíon?" BorderColor="White" BorderWidth="0" Font-Size="28" Font-Bold="True" Width="783px"></asp:TextBox>
    </div>
    <div align="left">
        <p>
            Si
        </p>
    </div>

    <div align="left">
        <asp:TextBox runat="server" Text="¿Por qué hay tanto Furry?" BorderColor="White" BorderWidth="0" Font-Size="28" Font-Bold="True" Width="783px"></asp:TextBox>
    </div>
    <div align="left">
        <p>
            Preguntenle al Einyel
        </p>
        <asp:Image runat="server" ImageUrl="../Imagenes/Random/w3w2xjbnfg3wziwg3jel.gif"/>
    </div>
</asp:Content>
