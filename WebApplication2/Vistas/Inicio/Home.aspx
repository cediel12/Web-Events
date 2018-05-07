<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PaginaWeb.Vistas.Inicio.Home" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="hero">
        <div class="hero-container">
            <h1>Bienvenido a Eventium</h1>
            <h2>El mejor sitio para estar informado sobre los eventos de la Universidad de la Amazonia</h2>
            <a href="Login.aspx" class="btn-get-started">Iniciar Sesion</a>
        </div>
    </section>

    <%--desarrolladores--%>

    <section id="team">
        <div class="container wow fadeInUp">
            <div class="section-header">
                <h3 class="section-title">Grupo de trabajo</h3>
                <p class="section-description">Miembros desarrolladores del proyecto</p>
            </div>
            <div class="row">
                <div class="col-lg-3 col-md-6">
                    <div class="member">
                        <div class="pic">
                            <img src="img/team-1.jpg" alt=""></div>
                        <h4>Victor Cediel</h4>
                        <span>Desarrollador - Director</span>
                        <div class="social">
                            <a href=""><i class="fa fa-twitter"></i></a>
                            <a href=""><i class="fa fa-facebook"></i></a>
                            <a href=""><i class="fa fa-google-plus"></i></a>
                            <a href=""><i class="fa fa-linkedin"></i></a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-3 col-md-6">
                    <div class="member">
                        <div class="pic">
                            <img src="img/team-2.jpg" alt=""></div>
                        <h4>Nicolas Cardenas</h4>
                        <span>Desarrollador - Director</span>
                        <div class="social">
                            <a href=""><i class="fa fa-twitter"></i></a>
                            <a href=""><i class="fa fa-facebook"></i></a>
                            <a href=""><i class="fa fa-google-plus"></i></a>
                            <a href=""><i class="fa fa-linkedin"></i></a>
                        </div>
                    </div>
                </div>

                <div class="col-lg-3 col-md-6">
                    <div class="member">
                        <div class="pic">
                            <img src="img/team-3.jpg" alt=""></div>
                        <h4>Rubem Ordoñez</h4>
                        <span>Desarrollador - Director</span>
                        <div class="social">
                            <a href=""><i class="fa fa-twitter"></i></a>
                            <a href=""><i class="fa fa-facebook"></i></a>
                            <a href=""><i class="fa fa-google-plus"></i></a>
                            <a href=""><i class="fa fa-linkedin"></i></a>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
    

    <%--contacto--%>

    <section id="contact">
        <div class="container wow fadeInUp">
            <div class="section-header">
                <h3 class="section-title">Contacto</h3>
                <p class="section-description">Todas las dudas y sugerencias pudes enviarlas o acceder a nuestro sitio fisico</p>
            </div>
        </div>

        <div id="google-map" data-latitude="1.620141" data-longitude="-75.604618"></div>

        <div class="container wow fadeInUp">
            <div class="row justify-content-center">

                <div class="col-lg-3 col-md-4">

                    <div class="info">
                        <div>
                            <i class="fa fa-map-marker"></i>
                            <p>#4-1 a, Cl. 17 #4451
                                <br>
                                Florencia, Caquetá</p>
                        </div>

                        <div>
                            <i class="fa fa-envelope"></i>
                            <p>victorcediel@hotmail.es</p>
                        </div>

                        <div>
                            <i class="fa fa-phone"></i>
                            <p>+57 3142621543</p>
                        </div>
                    </div>

                    <div class="social-links">
                        <a href="#" class="twitter"><i class="fa fa-twitter"></i></a>
                        <a href="#" class="facebook"><i class="fa fa-facebook"></i></a>
                        <a href="#" class="instagram"><i class="fa fa-instagram"></i></a>
                        <a href="#" class="google-plus"><i class="fa fa-google-plus"></i></a>
                        <a href="#" class="linkedin"><i class="fa fa-linkedin"></i></a>
                    </div>

                </div>

                <div class="col-lg-5 col-md-8">
                    <div class="form">
                        <div id="sendmessage">Gracias por utilizar el servicio de sugerencias. Seran tomasdas lo mas pronto posible!</div>
                        <div id="errormessage"></div>
                        <form action="" method="post" role="form" class="contactForm">
                            <div class="form-group">
                                <input type="text" name="name" class="form-control" id="name" placeholder="Nombre" data-rule="minlen:4" data-msg="Please enter at least 4 chars" />
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <input type="email" class="form-control" name="email" id="email" placeholder="Email" data-rule="email" data-msg="Please enter a valid email" />
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <input type="text" class="form-control" name="subject" id="subject" placeholder="Motivo" data-rule="minlen:4" data-msg="Please enter at least 8 chars of subject" />
                                <div class="validation"></div>
                            </div>
                            <div class="form-group">
                                <textarea class="form-control" name="message" rows="5" data-rule="required" data-msg="Please write something for us" placeholder="Mensaje"></textarea>
                                <div class="validation"></div>
                            </div>
                            <div class="text-center">
                                <button type="submit">Enviar Mensaje</button></div>
                        </form>
                    </div>
                </div>

            </div>

        </div>
    </section>
    
</asp:Content>
