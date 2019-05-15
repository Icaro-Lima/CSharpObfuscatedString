//
// Original work Copyright (c) 2013 Urban Apps
// Modified work Copyright 2019 Ícaro Lima
//
// Licensed under the MIT License. See LICENSE file in the project root for
// full license information.
//

using System.Text;

public static class CSharpObfuscatedStringBuilder
{
    // MARK: - a-z -
    public static StringBuilder a(this StringBuilder str) { return str.Append("a"); }
    public static StringBuilder b(this StringBuilder str) { return str.Append("b"); }
    public static StringBuilder c(this StringBuilder str) { return str.Append("c"); }
    public static StringBuilder d(this StringBuilder str) { return str.Append("d"); }
    public static StringBuilder e(this StringBuilder str) { return str.Append("e"); }
    public static StringBuilder f(this StringBuilder str) { return str.Append("f"); }
    public static StringBuilder g(this StringBuilder str) { return str.Append("g"); }
    public static StringBuilder h(this StringBuilder str) { return str.Append("h"); }
    public static StringBuilder i(this StringBuilder str) { return str.Append("i"); }
    public static StringBuilder j(this StringBuilder str) { return str.Append("j"); }
    public static StringBuilder k(this StringBuilder str) { return str.Append("k"); }
    public static StringBuilder l(this StringBuilder str) { return str.Append("l"); }
    public static StringBuilder m(this StringBuilder str) { return str.Append("m"); }
    public static StringBuilder n(this StringBuilder str) { return str.Append("n"); }
    public static StringBuilder o(this StringBuilder str) { return str.Append("o"); }
    public static StringBuilder p(this StringBuilder str) { return str.Append("p"); }
    public static StringBuilder q(this StringBuilder str) { return str.Append("q"); }
    public static StringBuilder r(this StringBuilder str) { return str.Append("r"); }
    public static StringBuilder s(this StringBuilder str) { return str.Append("s"); }
    public static StringBuilder t(this StringBuilder str) { return str.Append("t"); }
    public static StringBuilder u(this StringBuilder str) { return str.Append("u"); }
    public static StringBuilder v(this StringBuilder str) { return str.Append("v"); }
    public static StringBuilder w(this StringBuilder str) { return str.Append("w"); }
    public static StringBuilder x(this StringBuilder str) { return str.Append("x"); }
    public static StringBuilder y(this StringBuilder str) { return str.Append("y"); }
    public static StringBuilder z(this StringBuilder str) { return str.Append("z"); }

    // MARK: - A-Z -
    public static StringBuilder A(this StringBuilder str) { return str.Append("A"); }
    public static StringBuilder B(this StringBuilder str) { return str.Append("B"); }
    public static StringBuilder C(this StringBuilder str) { return str.Append("C"); }
    public static StringBuilder D(this StringBuilder str) { return str.Append("D"); }
    public static StringBuilder E(this StringBuilder str) { return str.Append("E"); }
    public static StringBuilder F(this StringBuilder str) { return str.Append("F"); }
    public static StringBuilder G(this StringBuilder str) { return str.Append("G"); }
    public static StringBuilder H(this StringBuilder str) { return str.Append("H"); }
    public static StringBuilder I(this StringBuilder str) { return str.Append("I"); }
    public static StringBuilder J(this StringBuilder str) { return str.Append("J"); }
    public static StringBuilder K(this StringBuilder str) { return str.Append("K"); }
    public static StringBuilder L(this StringBuilder str) { return str.Append("L"); }
    public static StringBuilder M(this StringBuilder str) { return str.Append("M"); }
    public static StringBuilder N(this StringBuilder str) { return str.Append("N"); }
    public static StringBuilder O(this StringBuilder str) { return str.Append("O"); }
    public static StringBuilder P(this StringBuilder str) { return str.Append("P"); }
    public static StringBuilder Q(this StringBuilder str) { return str.Append("Q"); }
    public static StringBuilder R(this StringBuilder str) { return str.Append("R"); }
    public static StringBuilder S(this StringBuilder str) { return str.Append("S"); }
    public static StringBuilder T(this StringBuilder str) { return str.Append("T"); }
    public static StringBuilder U(this StringBuilder str) { return str.Append("U"); }
    public static StringBuilder V(this StringBuilder str) { return str.Append("V"); }
    public static StringBuilder W(this StringBuilder str) { return str.Append("W"); }
    public static StringBuilder X(this StringBuilder str) { return str.Append("X"); }
    public static StringBuilder Y(this StringBuilder str) { return str.Append("Y"); }
    public static StringBuilder Z(this StringBuilder str) { return str.Append("Z"); }

    // MARK: - Numbers -
    public static StringBuilder _1(this StringBuilder str) { return str.Append("1"); }
    public static StringBuilder _2(this StringBuilder str) { return str.Append("2"); }
    public static StringBuilder _3(this StringBuilder str) { return str.Append("3"); }
    public static StringBuilder _4(this StringBuilder str) { return str.Append("4"); }
    public static StringBuilder _5(this StringBuilder str) { return str.Append("5"); }
    public static StringBuilder _6(this StringBuilder str) { return str.Append("6"); }
    public static StringBuilder _7(this StringBuilder str) { return str.Append("7"); }
    public static StringBuilder _8(this StringBuilder str) { return str.Append("8"); }
    public static StringBuilder _9(this StringBuilder str) { return str.Append("9"); }
    public static StringBuilder _0(this StringBuilder str) { return str.Append("0"); }

    // MARK: - Punctuation -
    public static StringBuilder space(this StringBuilder str) { return str.Append(" "); }
    public static StringBuilder point(this StringBuilder str) { return str.Append("."); }
    public static StringBuilder dash(this StringBuilder str) { return str.Append("-"); }
    public static StringBuilder comma(this StringBuilder str) { return str.Append(","); }
    public static StringBuilder semicolon(this StringBuilder str) { return str.Append(");"); }
    public static StringBuilder colon(this StringBuilder str) { return str.Append(":"); }
    public static StringBuilder apostrophe(this StringBuilder str) { return str.Append("'"); }
    public static StringBuilder quotation(this StringBuilder str) { return str.Append("\""); }
    public static StringBuilder plus(this StringBuilder str) { return str.Append("+"); }
    public static StringBuilder equals(this StringBuilder str) { return str.Append("="); }
    public static StringBuilder paren_left(this StringBuilder str) { return str.Append("("); }
    public static StringBuilder paren_right(this StringBuilder str) { return str.Append(")"); }
    public static StringBuilder asterisk(this StringBuilder str) { return str.Append("*"); }
    public static StringBuilder ampersand(this StringBuilder str) { return str.Append("&"); }
    public static StringBuilder caret(this StringBuilder str) { return str.Append("^"); }
    public static StringBuilder percent(this StringBuilder str) { return str.Append("%"); }
    public static StringBuilder dollar(this StringBuilder str) { return str.Append("$"); }
    public static StringBuilder pound(this StringBuilder str) { return str.Append("#"); }
    public static StringBuilder at(this StringBuilder str) { return str.Append("@"); }
    public static StringBuilder exclamation(this StringBuilder str) { return str.Append("!"); }
    public static StringBuilder question_mark(this StringBuilder str) { return str.Append("?"); }
    public static StringBuilder back_slash(this StringBuilder str) { return str.Append("\\"); }
    public static StringBuilder forward_slash(this StringBuilder str) { return str.Append("/"); }
    public static StringBuilder curly_left(this StringBuilder str) { return str.Append("{"); }
    public static StringBuilder curly_right(this StringBuilder str) { return str.Append("}"); }
    public static StringBuilder bracket_left(this StringBuilder str) { return str.Append("["); }
    public static StringBuilder bracket_right(this StringBuilder str) { return str.Append("]"); }
    public static StringBuilder bar(this StringBuilder str) { return str.Append("|"); }
    public static StringBuilder less_than(this StringBuilder str) { return str.Append("<"); }
    public static StringBuilder greater_than(this StringBuilder str) { return str.Append(">"); }
    public static StringBuilder underscore(this StringBuilder str) { return str.Append("_"); }

    // MARK: - Aliases -
    public static StringBuilder dot(this StringBuilder str) { return point(new StringBuilder()); }
}
