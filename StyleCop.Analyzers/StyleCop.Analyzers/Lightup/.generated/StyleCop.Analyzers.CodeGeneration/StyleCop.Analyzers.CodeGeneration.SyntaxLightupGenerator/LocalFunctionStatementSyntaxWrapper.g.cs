﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using System;
    using System.Collections.Immutable;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    internal readonly partial struct LocalFunctionStatementSyntaxWrapper : ISyntaxWrapper<StatementSyntax>
    {
        internal const string WrappedTypeName = "Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax";
        private static readonly Type WrappedType;
        private readonly StatementSyntax node;
        private static readonly Func<StatementSyntax, SyntaxTokenList> ModifiersAccessor;
        private static readonly Func<StatementSyntax, TypeSyntax> ReturnTypeAccessor;
        private static readonly Func<StatementSyntax, SyntaxToken> IdentifierAccessor;
        private static readonly Func<StatementSyntax, TypeParameterListSyntax> TypeParameterListAccessor;
        private static readonly Func<StatementSyntax, ParameterListSyntax> ParameterListAccessor;
        private static readonly Func<StatementSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesAccessor;
        private static readonly Func<StatementSyntax, BlockSyntax> BodyAccessor;
        private static readonly Func<StatementSyntax, ArrowExpressionClauseSyntax> ExpressionBodyAccessor;
        private static readonly Func<StatementSyntax, SyntaxToken> SemicolonTokenAccessor;
        private static readonly Func<StatementSyntax, SyntaxList<AttributeListSyntax>, StatementSyntax> WithAttributeListsAccessor;
        private static readonly Func<StatementSyntax, SyntaxTokenList, StatementSyntax> WithModifiersAccessor;
        private static readonly Func<StatementSyntax, TypeSyntax, StatementSyntax> WithReturnTypeAccessor;
        private static readonly Func<StatementSyntax, SyntaxToken, StatementSyntax> WithIdentifierAccessor;
        private static readonly Func<StatementSyntax, TypeParameterListSyntax, StatementSyntax> WithTypeParameterListAccessor;
        private static readonly Func<StatementSyntax, ParameterListSyntax, StatementSyntax> WithParameterListAccessor;
        private static readonly Func<StatementSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, StatementSyntax> WithConstraintClausesAccessor;
        private static readonly Func<StatementSyntax, BlockSyntax, StatementSyntax> WithBodyAccessor;
        private static readonly Func<StatementSyntax, ArrowExpressionClauseSyntax, StatementSyntax> WithExpressionBodyAccessor;
        private static readonly Func<StatementSyntax, SyntaxToken, StatementSyntax> WithSemicolonTokenAccessor;
        static LocalFunctionStatementSyntaxWrapper()
        {
            WrappedType = SyntaxWrapperHelper.GetWrappedType(typeof(LocalFunctionStatementSyntaxWrapper));
            ModifiersAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxTokenList>(WrappedType, nameof(Modifiers));
            ReturnTypeAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, TypeSyntax>(WrappedType, nameof(ReturnType));
            IdentifierAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(Identifier));
            TypeParameterListAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, TypeParameterListSyntax>(WrappedType, nameof(TypeParameterList));
            ParameterListAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, ParameterListSyntax>(WrappedType, nameof(ParameterList));
            ConstraintClausesAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>>(WrappedType, nameof(ConstraintClauses));
            BodyAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, BlockSyntax>(WrappedType, nameof(Body));
            ExpressionBodyAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, ArrowExpressionClauseSyntax>(WrappedType, nameof(ExpressionBody));
            SemicolonTokenAccessor = LightupHelpers.CreateSyntaxPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(SemicolonToken));
            WithAttributeListsAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxList<AttributeListSyntax>>(WrappedType, nameof(StatementSyntax.AttributeLists));
            WithModifiersAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxTokenList>(WrappedType, nameof(Modifiers));
            WithReturnTypeAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, TypeSyntax>(WrappedType, nameof(ReturnType));
            WithIdentifierAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(Identifier));
            WithTypeParameterListAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, TypeParameterListSyntax>(WrappedType, nameof(TypeParameterList));
            WithParameterListAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, ParameterListSyntax>(WrappedType, nameof(ParameterList));
            WithConstraintClausesAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>>(WrappedType, nameof(ConstraintClauses));
            WithBodyAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, BlockSyntax>(WrappedType, nameof(Body));
            WithExpressionBodyAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, ArrowExpressionClauseSyntax>(WrappedType, nameof(ExpressionBody));
            WithSemicolonTokenAccessor = LightupHelpers.CreateSyntaxWithPropertyAccessor<StatementSyntax, SyntaxToken>(WrappedType, nameof(SemicolonToken));
        }

        private LocalFunctionStatementSyntaxWrapper(StatementSyntax node)
        {
            this.node = node;
        }

        public StatementSyntax SyntaxNode => this.node;
        public static explicit operator LocalFunctionStatementSyntaxWrapper(SyntaxNode node)
        {
            if (node == null)
            {
                return default;
            }

            if (!IsInstance(node))
            {
                throw new InvalidCastException($"Cannot cast '{node.GetType().FullName}' to '{WrappedTypeName}'");
            }

            return new LocalFunctionStatementSyntaxWrapper((StatementSyntax)node);
        }

        public static implicit operator StatementSyntax(LocalFunctionStatementSyntaxWrapper wrapper)
        {
            return wrapper.node;
        }

        public static bool IsInstance(SyntaxNode node)
        {
            return node != null && LightupHelpers.CanWrapNode(node, WrappedType);
        }
    }
}
