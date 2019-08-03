﻿// ------------------------------------------------------------------------------
// <copyright file="ConstantExpressionTranspiler.cs" company="Drake53">
// Copyright (c) 2019 Drake53. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable SA1649 // File name should match first type name

using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace War3Net.CodeAnalysis.Jass.Transpilers
{
    public static partial class JassToCSharpTranspiler
    {
        public static ExpressionSyntax Transpile(this Syntax.ConstantExpressionSyntax constantExpressionNode)
        {
            _ = constantExpressionNode ?? throw new ArgumentNullException(nameof(constantExpressionNode));

            return constantExpressionNode.IntegerExpressionNode?.Transpile()
                ?? constantExpressionNode.RealExpressionNode?.TranspileExpression()
                ?? constantExpressionNode.BooleanExpressionNode?.Transpile()
                ?? constantExpressionNode.StringExpressionNode?.Transpile()
                ?? constantExpressionNode.NullExpressionNode.TranspileExpression();
        }

        public static ExpressionSyntax Transpile(this Syntax.ConstantExpressionSyntax constantExpressionNode, out bool @const)
        {
            _ = constantExpressionNode ?? throw new ArgumentNullException(nameof(constantExpressionNode));

            @const = true;

            return constantExpressionNode.IntegerExpressionNode?.Transpile()
                ?? constantExpressionNode.RealExpressionNode?.TranspileExpression()
                ?? constantExpressionNode.BooleanExpressionNode?.Transpile()
                ?? constantExpressionNode.StringExpressionNode?.Transpile()
                ?? constantExpressionNode.NullExpressionNode.TranspileExpression();
        }
    }
}