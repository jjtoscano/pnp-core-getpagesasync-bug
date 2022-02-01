using System;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using AngleSharp.Html.Parser;

namespace BodyHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Uri.EscapeUriString("https://cognito-idp.eu-west-1.amazonaws.com/eu-west-1_EpkF5jjH3/.well-known/jwks.json");

            #region CANVAS

            //var canvas = "<div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.0\" data-sp-controldata=\"&#123;&quot;editorType&quot;&#58;&quot;CKEditor&quot;,&quot;controlType&quot;&#58;4,&quot;id&quot;&#58;&quot;8f913615-5557-4af2-b2ab-1d9f10e3a4fc&quot;,&quot;position&quot;&#58;&#123;&quot;controlIndex&quot;&#58;1.0,&quot;zoneIndex&quot;&#58;1.0,&quot;sectionIndex&quot;&#58;1,&quot;sectionFactor&quot;&#58;12,&quot;layoutIndex&quot;&#58;1&#125;,&quot;emphasis&quot;&#58;&#123;&quot;zoneEmphasis&quot;&#58;0&#125;&#125;\"><div data-sp-rte=\"\"><p><span><span><span><strong><span><span><span>ACCIONA ha recibido la certificación de Top Employer 2022</span></span></span></strong><span><span><span>&#160;en España, Brasil, México, Australia, EE.UU. y Canadá. Este sello reconoce a la Compañía como una de las&#160;<strong><span>mejores empresas para trabajar</span></strong>&#160;y destaca su excelencia en la gestión de personas.</span></span></span></span></span></span></p><p><span><span><span><span><span><span>Además, también hemos recibido el sello Top Employer Norteamérica, que avala a la Compañía como una de las mejores empresas empleadoras de la región.</span></span></span></span></span></span></p><p><span><span><span><span><span><span>Esta certificación es un reconocimiento&#160;a nuestro firme compromiso de promover valores como la sostenibilidad, la diversidad e inclusión, la atracción de talento o la digitalización, entre otros.</span></span></span></span></span></span></p></div></div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.0\" data-sp-controldata=\"&#123;&quot;controlType&quot;&#58;0,&quot;pageSettingsSlice&quot;&#58;&#123;&quot;isDefaultDescription&quot;&#58;false,&quot;isDefaultThumbnail&quot;&#58;true&#125;&#125;\"></div></div>";
            //var pageHeaderHtml = "<div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.4\" data-sp-controldata=\"&#123;&quot;id&quot;&#58;&quot;cbe7b0a9-3504-44dd-a3a3-0e5cacd07788&quot;,&quot;instanceId&quot;&#58;&quot;cbe7b0a9-3504-44dd-a3a3-0e5cacd07788&quot;,&quot;title&quot;&#58;&quot;Title Region&quot;,&quot;description&quot;&#58;&quot;Title Region Description&quot;,&quot;serverProcessedContent&quot;&#58;&#123;&quot;htmlStrings&quot;&#58;&#123;&#125;,&quot;searchablePlainTexts&quot;&#58;&#123;&#125;,&quot;imageSources&quot;&#58;&#123;&quot;imageSource&quot;&#58;&quot;https&#58;//rubik1.sharepoint.com/_layouts/15/getpreview.ashx?path=%2Fsites%2FNoticiasmash%2FSiteAssets%2FSomos%2520Top%2520Employer%25202022.png&quot;&#125;,&quot;links&quot;&#58;&#123;&#125;,&quot;customMetadata&quot;&#58;&#123;&quot;imageSource&quot;&#58;&#123;&quot;siteId&quot;&#58;&quot;fa839274-a3f9-4ea1-a956-808a75f17a23&quot;,&quot;webId&quot;&#58;&quot;38d36c15-efa7-4c3c-97f4-a938428f4fb5&quot;,&quot;listId&quot;&#58;&quot;00000000-0000-0000-0000-000000000000&quot;,&quot;uniqueId&quot;&#58;&quot;00000000-0000-0000-0000-000000000000&quot;&#125;&#125;&#125;,&quot;dataVersion&quot;&#58;&quot;1.4&quot;,&quot;properties&quot;&#58;&#123;&quot;title&quot;&#58;&quot;¡Somos Top Employer 2022!&quot;,&quot;imageSourceType&quot;&#58;2,&quot;layoutType&quot;&#58;&quot;FullWidthImage&quot;,&quot;textAlignment&quot;&#58;&quot;Left&quot;,&quot;showTopicHeader&quot;&#58;false,&quot;showPublishDate&quot;&#58;false,&quot;topicHeader&quot;&#58;&quot;&quot;,&quot;authorByline&quot;&#58;[],&quot;authors&quot;&#58;[],&quot;altText&quot;&#58;&quot;&quot;,&quot;webId&quot;&#58;&quot;38d36c15-efa7-4c3c-97f4-a938428f4fb5&quot;,&quot;siteId&quot;&#58;&quot;fa839274-a3f9-4ea1-a956-808a75f17a23&quot;,&quot;listId&quot;&#58;&quot;00000000-0000-0000-0000-000000000000&quot;,&quot;uniqueId&quot;&#58;&quot;00000000-0000-0000-0000-000000000000&quot;,&quot;&qtranslateXuot;&#58;0,&quot;translateY&quot;&#58;0&#125;&#125;\"></div></div>";

            var canvas = "<div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.0\" data-sp-controldata=\"&#123;&quot;editorType&quot;&#58;&quot;CKEditor&quot;,&quot;controlType&quot;&#58;4,&quot;id&quot;&#58;&quot;080116a3-d62e-4cf5-9c87-1d14d0c93a6e&quot;,&quot;position&quot;&#58;&#123;&quot;controlIndex&quot;&#58;1,&quot;zoneIndex&quot;&#58;1,&quot;sectionIndex&quot;&#58;1,&quot;sectionFactor&quot;&#58;12,&quot;layoutIndex&quot;&#58;1&#125;,&quot;emphasis&quot;&#58;&#123;&quot;zoneEmphasis&quot;&#58;0&#125;,&quot;addedFromPersistedData&quot;&#58;true,&quot;zoneGroupMetadata&quot;&#58;&#123;&quot;type&quot;&#58;0&#125;&#125;\"><div data-sp-rte=\"\"><p><span><span><span><span><span><span>ACCIONA ha obtenido la certificación&#160;<em><span>Top Employer 2022</span></em>&#160;en España, Brasil, México, Australia, EEUU y Canadá, además de hacerse con el sello&#160;<em><span>Top Employers Norteamérica</span></em>, que la avala como una de las mejores empresas empleadoras del continente.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>ACCIONA revalida así el certificado&#160;<em><span>Top Employer España</span></em>&#160;que obtuvo por primera vez en 2021 y acredita su liderazgo en la gestión de los recursos humanos en otros cinco de sus principales mercados internacionales.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>La certificación, otorgada por Top Employers Institute, es una de las más exigentes y prestigiosas del mundo en el ámbito de la gestión corporativa de personas.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>Para obtener esta acreditación, las organizaciones son evaluadas mediante la&#160;<em><span>HR Best Practices Survey,&#160;</span></em>que analiza aspectos relacionados con una veintena de temas como la estrategia de personas, el entorno de trabajo, la captación de talento, la formación, la promoción del bienestar de los empleados y la diversidad e inclusión, entre otros.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>ACCIONA ha obtenido el sello&#160;<em><span>Top Employer 2022&#160;</span></em>por su gestión de los Recursos Humanos que promueve los valores de respeto, igualdad de oportunidades, diversidad, equilibrio de género, mérito y comunicación continua.</span></span></span></span></span></span></p><p><span><span><span><span><span><span>&quot;Al reflexionar sobre el exigente año que, al igual que el anterior, ha afectado a organizaciones de todo el mundo, ACCIONA ha seguido demostrando que da prioridad al mantenimiento de excelentes prácticas de personal en el lugar de trabajo. Sigue afrontando los retos del cambiante mundo laboral, al tiempo que trabaja incansablemente para tener un impacto positivo en la vida de sus trabajadores&quot;, afirma David Plinkm director general del Top Employers Institute.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>Top Employers Institute es una organización global de referencia en el reconocimiento de la excelencia de las prácticas de recursos humanos.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>El programa Top Employers ha certificado, desde hace más de treinta años, a más de 1.850 compañías en 123 países en los cinco continentes. Estas empresas impactan positivamente en las vidas de más de 8 millones de empleados en todo el mundo.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span>&#160;</span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><strong><span><span><span>DIFERENCIA&#160;SOSTENIBLE</span></span></span></strong></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>ACCIONA, a través de su estrategia&#160;<em><span>People&#160;</span></em>de gestión integral de las personas, lidera iniciativas destinadas a incentivar la diversidad en su plantilla, la igualdad de género, la promoción del talento y la sostenibilidad.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>Una de estas iniciativas, que se aplica de manera trasversal en todos los proyectos de la compañía, es la denominada &quot;Diferencia Sostenible&quot;, en virtud de la que ACCIONA pone la gestión de personas en el centro de la estrategia de sostenibilidad de la compañía, al mismo nivel que los objetivos económicos y medioambientales.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>Otra de las iniciativas destacadas es &quot;Sostenibl@s 50&#58;50&quot; que promueve la inserción de la mujer en actividades tradicionalmente masculinas.&#160; Para lograrlo se identifica talento femenino local y se imparte formación para la ejecución de tareas especializadas. De esta manera, además de aumentar la empleabilidad de estas mujeres, se generan modelos replicables, eliminando los aún persistentes estigmas de la presencia femenina en determinadas actividades.&#160;</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>Un ejemplo de esta iniciativa lo encontramos en la Línea 6 de Metro de Sao Paulo en Brasil, donde la fábrica de dovelas cuenta con un 70% de mujeres en la plantilla. También destaca el Proyecto Loreto (Australia), donde ACCIONA ha logrado la paridad de género en la construcción de una escuela, y el Hospital Marga Marga (Chile), cuya sala cuna ha sido construida íntegramente por mujeres. En el ámbito de la energía cabe destacar el Proyecto Grid Code Conecta, en España -donde hay un 50% de mujeres en el equipo de código de red para la interconexión de proyectos de energía- y el proyecto Mujeres en el Itsmo, en Oaxaca (México), en el que se promueve la selección y desarrollo de mujeres ingenieras en el campo de la energía eólica.</span></span></span></span></span></span></p><p style=\"text-align&#58;justify;\"><span><span><span><span><span><span>ACCIONA cuenta actualmente con unos 38.000 empleados de 131 nacionalidades. En 2021, el índice Refinitiv Diversity &amp; Inclusion, situó a la compañía como la 36º mejor del mundo en materia de Diversidad e Inclusión social.</span></span></span></span></span></span></p></div></div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.0\" data-sp-controldata=\"&#123;&quot;controlType&quot;&#58;0,&quot;pageSettingsSlice&quot;&#58;&#123;&quot;isDefaultDescription&quot;&#58;false,&quot;isDefaultThumbnail&quot;&#58;true&#125;,&quot;htmlAttributes&quot;&#58;[&quot;modifiedDescription&quot;]&#125;\" data-sp-meta-modifiedDescription=\"\"></div></div>";
            var pageHeaderHtml = "<div><div data-sp-canvascontrol=\"\" data-sp-canvasdataversion=\"1.4\" data-sp-controldata=\"&#123;&quot;id&quot;&#58;&quot;cbe7b0a9-3504-44dd-a3a3-0e5cacd07788&quot;,&quot;instanceId&quot;&#58;&quot;cbe7b0a9-3504-44dd-a3a3-0e5cacd07788&quot;,&quot;title&quot;&#58;&quot;Title Region&quot;,&quot;description&quot;&#58;&quot;description Region&quot;,&quot;audiences&quot;&#58;[],&quot;serverProcessedContent&quot;&#58;&#123;&quot;htmlStrings&quot;&#58;&#123;&#125;,&quot;searchablePlainTexts&quot;&#58;&#123;&#125;,&quot;imageSources&quot;&#58;&#123;&quot;imageSource&quot;&#58;&quot;https&#58;//rubik1.sharepoint.com/sites/Noticiasmash/SiteAssets/ACCIONA%20logra%20el%20certificado%20Top%20Employer%202022%20en%20Espan%CC%83a%20Brasil,%20Me%CC%81xico%20Australia%20Canada%CC%81%20y%20EEUU.png&quot;&#125;,&quot;links&quot;&#58;&#123;&#125;,&quot;customMetadata&quot;&#58;&#123;&quot;imageSource&quot;&#58;&#123;&#125;&#125;&#125;,&quot;dataVersion&quot;&#58;&quot;1.4&quot;,&quot;properties&quot;&#58;&#123;&quot;title&quot;&#58;&quot;ACCIONA logra el certificado ‘Top Employer 2022’ en España, Brasil, México, Australia, Canadá y EEUU&quot;,&quot;imageSourceType&quot;&#58;2,&quot;type&quot;&#58;0,&quot;authorByline&quot;&#58;[],&quot;topicHeader&quot;&#58;&quot;&quot;,&quot;layoutType&quot;&#58;&quot;FullWidthImage&quot;,&quot;textAlignment&quot;&#58;&quot;Left&quot;,&quot;showTopicHeader&quot;&#58;false,&quot;showPublishDate&quot;&#58;false,&quot;authors&quot;&#58;[],&quot;imageServerRelativeUrl&quot;&#58;null,&quot;translateX&quot;&#58;null,&quot;translateY&quot;&#58;null,&quot;altText&quot;&#58;null,&quot;enableGradientEffect&quot;&#58;true&#125;,&quot;reservedHeight&quot;&#58;280&#125;\"></div></div>";

            string imageServerRelativeUrl = "", TopicHeader, Authors, AuthorByLine, AlternativeText;
            PageHeaderLayoutType LayoutType;
            PageHeaderTitleAlignment TextAlignment;
            bool ShowTopicHeader, ShowPublishDate, headerImageResolved;
            Guid siteId = Guid.Empty, webId = Guid.Empty, listId = Guid.Empty, uniqueId = Guid.Empty;
            PageHeaderType Type;
            double TranslateX, TranslateY;

            HtmlParser parser = new HtmlParser(new HtmlParserOptions() { IsEmbedded = true });
            using (var document = parser.ParseDocument(pageHeaderHtml))
            { 
                // select all control div's
                var pageHeaderControl = document.All.FirstOrDefault(m => m.HasAttribute("data-sp-controldata"));

                if (pageHeaderControl != null)
                {
                    string pageHeaderData = pageHeaderControl.GetAttribute("data-sp-controldata");
                    string decoded = "";

                    if (pageHeaderData.Contains("%7B") && pageHeaderData.Contains("%22") && pageHeaderData.Contains("%7D"))
                    {
                        decoded = WebUtility.UrlDecode(pageHeaderData);
                    }
                    else
                    {
                        decoded = WebUtility.HtmlDecode(pageHeaderData);
                    }

                    var wpJObject = JsonSerializer.Deserialize<JsonElement>(decoded);

                    // Store the server processed content as that's needed for full fidelity
                    if (wpJObject.TryGetProperty("serverProcessedContent", out JsonElement serverProcessedContent))
                    {
                        if (serverProcessedContent.TryGetProperty("imageSources", out JsonElement imageSources) && imageSources.TryGetProperty("imageSource", out JsonElement imageSource))
                        {
                            imageServerRelativeUrl = imageSource.GetString();
                        }

                        // Properties that apply to all header configurations
                        if (wpJObject.TryGetProperty("properties", out JsonElement properties))
                        {
                            if (properties.TryGetProperty("layoutType", out JsonElement layoutType))
                            {
                                LayoutType = (PageHeaderLayoutType)Enum.Parse(typeof(PageHeaderLayoutType), layoutType.GetString());
                            }

                            if (properties.TryGetProperty("textAlignment", out JsonElement textAlignment))
                            {
                                TextAlignment = (PageHeaderTitleAlignment)Enum.Parse(typeof(PageHeaderTitleAlignment), textAlignment.GetString());
                            }

                            if (properties.TryGetProperty("showTopicHeader", out JsonElement showTopicHeader))
                            {
                                ShowTopicHeader = showTopicHeader.GetBoolean();
                            }

                            if (properties.TryGetProperty("showPublishDate", out JsonElement showPublishDate))
                            {
                                ShowPublishDate = showPublishDate.GetBoolean();
                            }

                            if (properties.TryGetProperty("topicHeader", out JsonElement topicHeader))
                            {
                                TopicHeader = topicHeader.GetString();
                            }

                            if (properties.TryGetProperty("authors", out JsonElement authors))
                            {
                                Authors = authors.ToString();
                            }

                            if (properties.TryGetProperty("authorByline", out JsonElement authorByline))
                            {
                                AuthorByLine = authorByline.ToString();
                            }

                            // Specific properties that only apply when the header has a custom image
                            if (!string.IsNullOrEmpty(imageServerRelativeUrl))
                            {
                                Type = PageHeaderType.Custom;

                                if (properties.TryGetProperty("siteId", out JsonElement siteId1) && siteId1.TryGetGuid(out Guid siteIdGuid))
                                {
                                    siteId = siteIdGuid;
                                }

                                if (properties.TryGetProperty("webId", out JsonElement webId1) && webId1.TryGetGuid(out Guid webIdGuid))
                                {
                                    webId = webIdGuid;
                                }

                                if (properties.TryGetProperty("listId", out JsonElement listId1) && listId1.TryGetGuid(out Guid listIdGuid))
                                {
                                    listId = listIdGuid;
                                }

                                if (properties.TryGetProperty("uniqueId", out JsonElement uniqueId1) && uniqueId1.TryGetGuid(out Guid uniqueIdGuid))
                                {
                                    uniqueId = uniqueIdGuid;
                                }
                                if (siteId != Guid.Empty && webId != Guid.Empty && listId != Guid.Empty && uniqueId != Guid.Empty)
                                {
                                    headerImageResolved = true;
                                }

                                System.Globalization.CultureInfo usCulture = new System.Globalization.CultureInfo("en-US");
                                System.Globalization.CultureInfo europeanCulture = new System.Globalization.CultureInfo("nl-BE");

                                if (properties.TryGetProperty("translateX", out JsonElement translateXElement))
                                {
                                    var translateXEN = translateXElement.GetDecimal().ToString();

                                    System.Globalization.CultureInfo cultureToUse;
                                    if (translateXEN.Contains("."))
                                    {
                                        cultureToUse = usCulture;
                                    }
                                    else if (translateXEN.Contains(","))
                                    {
                                        cultureToUse = europeanCulture;
                                    }
                                    else
                                    {
                                        cultureToUse = usCulture;
                                    }

                                    double.TryParse(translateXEN, System.Globalization.NumberStyles.Float, cultureToUse, out double translateX);
                                    TranslateX = translateX;
                                }

                                if (properties.TryGetProperty("translateY", out JsonElement translateYElement))
                                {
                                    var translateYEN = translateYElement.GetDecimal().ToString();

                                    System.Globalization.CultureInfo cultureToUse;
                                    if (translateYEN.Contains("."))
                                    {
                                        cultureToUse = usCulture;
                                    }
                                    else if (translateYEN.Contains(","))
                                    {
                                        cultureToUse = europeanCulture;
                                    }
                                    else
                                    {
                                        cultureToUse = usCulture;
                                    }

                                    double.TryParse(translateYEN, System.Globalization.NumberStyles.Float, cultureToUse, out double translateY);
                                    TranslateY = translateY;
                                }

                                if (properties.TryGetProperty("altText", out JsonElement altText))
                                {
                                    AlternativeText = altText.GetString();
                                }
                            }
                            else
                            {
                                Type = PageHeaderType.Default;
                            }
                        }
                    }
                }
            }

            #endregion

        }
    }
}

