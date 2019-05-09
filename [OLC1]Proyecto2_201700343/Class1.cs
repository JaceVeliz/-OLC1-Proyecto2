using System;
using Irony.Parsing;
using Irony.Ast;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Proyecto2_201700343
{
    class Class1:Grammar
    {
        public Class1() : base(false)
        {
            CommentTerminal comentario1 = new CommentTerminal("comentario1", "<-", "->");
            CommentTerminal comentario2 = new CommentTerminal("comentario2", ">>", "\n", "\r\n");
            base.NonGrammarTerminals.Add(comentario1);
            base.NonGrammarTerminals.Add(comentario2);
            //Tipo de texto
            StringLiteral cadena = new StringLiteral("Cadena", "\"");
            StringLiteral caracter = new StringLiteral("Caracter", "\'");

            NumberLiteral entero = new NumberLiteral("entero");
            RegexBasedTerminal taleatorio = new RegexBasedTerminal("taleatorio", "[A-Z|a-z]([a-z|A-Z]|[0-9]|[_])*");
            RegexBasedTerminal tnumerocolor = new RegexBasedTerminal("tnumerocolor", "[#]([a-z|A-Z]|[0-9])+");
            RegexBasedTerminal decimales = new RegexBasedTerminal("decimales", "[0-9]+[.][0-9]+");
            IdentifierTerminal variable = new IdentifierTerminal("variable");
            var variable2 = new IdentifierTerminal("variable");
            
            var tclase = "clase";
            var toverride = "override";
            var tllavea = ("{");
            var tllavec = ("}");
            var tpuntoyc = (";");
            var tigual = ("=");
            var tarreglo = ("array");
            var tint = ("int");
            var tbool = ("bool");
            var tstring = ("string");
            var tdouble = ("double");
            var tchar = ("char");
            var tpublico = ("publico");
            var tprivado = ("privado");
            var tcoma = (",");
            var tcora = ("[");
            var tcorc = ("]");
            var ttrue = ("true");
            var tfalse = ("false");
            var timprimir = ("print");
            var tpara = ("(");
            var tparc = (")");
            var tshow = ("show");
            var tif = ("if");
            var telse = ("else");
            var tfor = ("for");
            var trepeat = ("repeat");
            var tmas2 = ("++");
            var tmenos2 = ("--");
            var tmas = ("+");
            var tmenos = ("-");
            var tdivision = ("/");
            var tpor = ("*");
            var tpotencia = ("^");
            var tigual2 = ("==");
            var tdiferentede = ("!=");
            var tmenorq = ("<");
            var tmayorq = (">");
            var tmenorigual = ("<=");
            var tmayorigual = (">=");
            var tor = ("||");
            var tand = ("&&");
            var tnegacion = ("!");
            var treturn = ("return");
            var tvoid = ("void");
            var timport = ("importar");
            var tmain = ("main");
            var tcomprobar = ("comprobar");
            var tcaso = ("caso");
            var twhile = ("while");
            var tdefecto = ("defecto");
            var tsalir = ("salir");
            var tcontinuar = ("continuar");
            var thacer = ("hacer");
            var tmientras = ("mientras");
            var tfigure = ("figure");
            var taddfigure = ("addfigure");
            var tcircle = ("circle");
            var ttriangle = ("triangle");
            var tsquare = ("square");
            var tline = ("line");
            var tcomillas = ("\"");
            var tred = ("red");
            var tblue = ("blue");
            var tgreen = ("green");
            var tgray = ("gray");
            var tbrown = ("brown");
            var tpink = ("pink");
            var tyellow = ("yellow");
            var tskyblue = ("skyblue");
            var torange = ("orange");
            var tblack = ("black");
            var twhite = ("white");
            var tdosp = (":");
            var tnew = ("new");

            NonTerminal Inicio = new NonTerminal("Inicio"),
                        Visibilidad = new NonTerminal("Visibilidad"),
                        Extends = new NonTerminal("Extends"),
                        Id = new NonTerminal("Id"),
                        Inicio2 = new NonTerminal("Inicio2"),
                        ListadeClases = new NonTerminal("ListadeClases"),
                        If = new NonTerminal("If"),
                        Else = new NonTerminal("Else"),
                        For = new NonTerminal("For"),
                        CondicionFor = new NonTerminal("CondicionFor"),
                        E = new NonTerminal("E"),
                        AumentooDisminucion = new NonTerminal("AumentooDisminucion"),
                        Repeat = new NonTerminal("Repeat"),
                        Datos = new NonTerminal("Datos"),
                        TipoValores = new NonTerminal("TipoValores"),
                        Posicion = new NonTerminal("Posicion"),
                        Declaracion = new NonTerminal("Declaracion"),
                        Asignacion = new NonTerminal("Asignacion"),
                        Funcion = new NonTerminal("Funcion"),
                        Funcion2 = new NonTerminal("Funcion2"),
                        Parametros = new NonTerminal("Parametros"),
                        Tipo = new NonTerminal("Tipo"),
                        Override = new NonTerminal("Override"),
                        Dimension = new NonTerminal("Dimension"),
                        Metodo = new NonTerminal("Metodo"),
                        Extends2 = new NonTerminal("Extends2"),
                        Dimension2 = new NonTerminal("Dimension2"),
                        Main = new NonTerminal("Main"),
                        LlamadaF = new NonTerminal("LlamadaF"),
                        While = new NonTerminal("While"),
                        Comprobar = new NonTerminal("Comprobar"),
                        Casos = new NonTerminal("Casos"),
                        Default = new NonTerminal("Default"),
                        Casos2 = new NonTerminal("Casos2"),
                        DoWhile = new NonTerminal("DoWhile"),
                        Figure = new NonTerminal("Figure"),
                        AddFigure = new NonTerminal("AddFigure"),
                        Geometricas = new NonTerminal("Geometricas"),
                        Color = new NonTerminal("Color"),
                        Cuerpo = new NonTerminal("Cuerpo"),
                        Continuar = new NonTerminal("Continuar"),
                        Salir = new NonTerminal("Salir"),
                        Asignacion2 = new NonTerminal("Asignacion2"),
                        Declaracion2 = new NonTerminal("Declaracion2"),
                        Objetos = new NonTerminal("Objetos"),
                        Asignacion3 = new NonTerminal("Asignacion3"),
                        Arreglo = new NonTerminal("Arreglo"),
                        Arreglo2 = new NonTerminal("Arreglo2"),
                        Asignarr = new NonTerminal("Asignarr"),
                        Asignarr2 = new NonTerminal("Asignarr2"),
                        Asignarr3 = new NonTerminal("Asignarr3"),
                        Listarr = new NonTerminal("Listarr"),
                        Imprimir = new NonTerminal("Imprimir"),
                        Mostrar = new NonTerminal("Mostrar"),
                        dClase = new NonTerminal("dClase"),
                        Parametros2 = new NonTerminal("Parametros2"),
                        Var2 = new NonTerminal("Var2"),
                        VarClase = new NonTerminal("VarClase");


            //Comienzo del analizador sintactico 

            Inicio.Rule = Visibilidad + ToTerm("clase") + Id + Extends + "{" + Inicio2 + "}" + ListadeClases;
            Inicio.ErrorRule = SyntaxError + ";";
            Inicio.ErrorRule = SyntaxError + "}";

            ListadeClases.Rule = Empty
                                | ListadeClases + Visibilidad + ToTerm("clase") + Id + Extends + "{" + Inicio2 + "}";
            ListadeClases.ErrorRule = SyntaxError + ";";
            ListadeClases.ErrorRule = SyntaxError + "}";

            Inicio2.Rule = Inicio2 + Cuerpo
                         | Cuerpo
                         | Empty;
            Cuerpo.Rule = Declaracion
                        | Asignacion
                        | AumentooDisminucion
                        | Imprimir
                        | Mostrar
                        | If
                        | For
                        | Repeat
                        | While
                        | Comprobar
                        | DoWhile
                        | Figure
                        | AddFigure
                        | Metodo
                        | Funcion
                        | Main
                        | LlamadaF
                        | Continuar
                        | Salir;
            
            Asignacion.Rule = Id  + Asignacion2 + ";";
            Asignacion.ErrorRule = SyntaxError + ";";

            Asignacion2.Rule = "=" + E;

            Declaracion.Rule = Visibilidad + Tipo + Declaracion2;

            Declaracion.ErrorRule = SyntaxError + ";";

            Declaracion2.Rule = Objetos + ";"
                                | tarreglo + Id + Arreglo + ";";

            Tipo.Rule =  ToTerm("int")
                        | ToTerm("bool")
                        | ToTerm("string")
                        | ToTerm("double")
                        | ToTerm("char")
                        | variable2
                        | ToTerm("void");

            Visibilidad.Rule = Empty
                                | tpublico
                                | tprivado;

            Objetos.Rule = Objetos + "," + Id + Asignacion3
                            | Id + Asignacion3;

            Asignacion3.Rule = "=" + E
                                | Empty;

            Arreglo.Rule = "[" + E + "]" + Arreglo2;

            Arreglo2.Rule = "[" + E + "]" + Arreglo2
                            | "=" + Asignarr
                            | Empty;

            Asignarr.Rule = "{"  + Asignarr2 + "}";

            Asignarr2.Rule = Asignarr3
                            | Listarr;

            Asignarr3.Rule = Asignarr
                            | Asignarr3 + "," + Asignarr;

            Listarr.Rule = Listarr + "," + E
                            | E;
            TipoValores.Rule = entero
                                | caracter
                                | cadena
                                | ttrue
                                | tfalse
                                | decimales;

            Imprimir.Rule = ToTerm("print") + "(" + E + ")" + ";";
            Imprimir.ErrorRule = SyntaxError + ";";

            Mostrar.Rule = ToTerm("show") + "(" + E + "," + E + ")" + ";";
            Mostrar.ErrorRule = SyntaxError + ";";

            If.Rule = ToTerm("if") + "(" + E + ")" + "{"  + Inicio2 + "}" + Else;
            If.ErrorRule = SyntaxError + "}";

            Else.Rule = ToTerm("else") + If
                        | ToTerm("else") + "{"  + Inicio2 + "}"
                        | Empty;
            Else.ErrorRule = SyntaxError + "}";

            For.Rule = ToTerm("for") + "(" + CondicionFor + E + ";" + AumentooDisminucion + ")" + "{" + Inicio2 + "}";
            For.ErrorRule = SyntaxError + "}";

            Repeat.Rule = ToTerm("repeat") + "(" + E + ")" + "{" + Inicio2 + "}";
            Repeat.ErrorRule = SyntaxError + "}";

            CondicionFor.Rule = Declaracion
                                | Asignacion;

            AumentooDisminucion.Rule = Datos + "++"
                                      | Datos + "--";

            Datos.Rule = TipoValores
                        | Id + Posicion;

            Posicion.Rule = "[" + E + "]" + Posicion
                            | Empty;

            Id.Rule = variable2;

            E.Rule = E + "+" + E
                    | E + "-" + E
                    | E + "/" + E
                    | E + "*" + E
                    | E + "^" + E
                    | E + "==" + E
                    | E + "!=" + E
                    | E + "<" + E
                    | E + ">" + E
                    | E + "<=" + E
                    | E + ">=" + E
                    | E + "||" + E
                    | E + "&&" + E
                    | E + "!" + E
                    | Datos
                    | dClase
                    | VarClase
                    | Id+"("+Parametros+")"+";"
                    | "(" + E + ")"
                    | "-" + E;

            Funcion.Rule = Visibilidad + Id + Funcion2 + "(" + Parametros + ")" + "{" + Inicio2 + treturn + E + ";" + "}";
            Funcion.ErrorRule = SyntaxError + "}";

            Funcion2.Rule = Tipo + Override
                            | ToTerm("array") + Tipo + Dimension + Override;

            Metodo.Rule = Visibilidad + Id + tvoid + Override + "(" + Parametros + ")" + "{" + Inicio2 + "}";
            Metodo.ErrorRule = SyntaxError + "}";

            Extends.Rule = ToTerm("importar") + Id + Extends2
                                | Empty;

            Extends2.Rule = "," + Id + Extends2
                            | Empty;

            Dimension.Rule = "[" + "]" + Dimension2;

            Dimension2.Rule = "[" + "]" + Dimension2
                            | Empty;

            Main.Rule = ToTerm("main") + "(" + ")" + "{" + Inicio2 + "}";
            Main.ErrorRule = SyntaxError + "}";

            LlamadaF.Rule = Id + "(" + Parametros + ")" +";";
            LlamadaF.ErrorRule = SyntaxError + ";";

            While.Rule = ToTerm("while") + "(" + E + ")" + "{" + Inicio2 + "}";
            While.ErrorRule = SyntaxError + "}";

            Comprobar.Rule = ToTerm("comprobar") + "(" + E + ")" + "{" + Casos + Default + "}";
            Comprobar.ErrorRule = SyntaxError + "}";
            Comprobar.ErrorRule = SyntaxError + ";";

            Casos.Rule = Casos2 + ToTerm("caso") + E + ":" + Inicio2 + tsalir + ";" ;

            Casos2.Rule = Empty 
                        | Casos2 + ToTerm("caso") + E + ":" + Inicio2 + tsalir + ";";

            Default.Rule = ToTerm("defecto") + ":" + Inicio2 + tsalir + ";"
                            | Empty;

            DoWhile.Rule = ToTerm("hacer") + "{" + Inicio2 + "}" + tmientras + "(" + E + ")" + ";";
            DoWhile.ErrorRule = SyntaxError + "}";
            DoWhile.ErrorRule = SyntaxError + ";";

            Figure.Rule = ToTerm("figure") + "(" + E + ")" + ";";
            Figure.ErrorRule = SyntaxError + ";";

            AddFigure.Rule = ToTerm("addfigure") + "(" + Geometricas + ")" + ";";
            AddFigure.ErrorRule = SyntaxError + ";";

            Geometricas.Rule = ToTerm("circle") + "(" + Color + "," + E + "," + E + "," + E + "," + E + ")"
                                | ToTerm("triangle") + "(" + Color + "," + E + "," + E + "," + E + "," + E + "," + E + "," + E + "," + E + ")"
                                | ToTerm("square") + "(" + Color + "," + E + "," + E + "," + E + "," + E + "," + E + ")"
                                | ToTerm("line") + "(" + Color + "," + E + "," + E + "," + E + "," + E + "," + E + ")";

            Color.Rule = "\""+tnumerocolor+"\""
                        | E ;

            

            Continuar.Rule = tcontinuar;

            Salir.Rule = tsalir;

            Override.Rule = ToTerm("override")
                            |Empty;
            dClase.Rule = tnew + Id + "(" + Parametros + ")";

            Parametros.Rule = Tipo + Parametros2
                                |Empty;

            Parametros2.Rule = Id + Var2
                            | tarreglo + Id + Arreglo + Var2;

            Var2.Rule = "," + Tipo + Parametros2
                        | Empty;

            VarClase.Rule = variable2 + "." + variable2 +"("+Parametros+")";
            this.Root = Inicio;

            RegisterOperators(1, Associativity.Right,"^");
            RegisterOperators(2, Associativity.Left, "*", "/");
            RegisterOperators(3, Associativity.Left, "+", "-");
            RegisterOperators(4, Associativity.Left, "==", "!=", "<", "<=", ">", ">=S");
            RegisterOperators(5, Associativity.Left, "!");
            RegisterOperators(6, Associativity.Left, "&&");
            RegisterOperators(7, Associativity.Left, "||");

        }

    }
}
