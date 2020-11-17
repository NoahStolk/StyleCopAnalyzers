﻿// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace StyleCop.Analyzers.Lightup
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    internal partial struct ParenthesizedVariableDesignationSyntaxWrapper : ISyntaxWrapper<CSharpSyntaxNode>
    {
        public SyntaxToken OpenParenToken
        {
            get
            {
                return OpenParenTokenAccessor(this.SyntaxNode);
            }
        }

        public SeparatedSyntaxListWrapper<VariableDesignationSyntaxWrapper> Variables
        {
            get
            {
                return VariablesAccessor(this.SyntaxNode);
            }
        }

        public SyntaxToken CloseParenToken
        {
            get
            {
                return CloseParenTokenAccessor(this.SyntaxNode);
            }
        }

        public static explicit operator ParenthesizedVariableDesignationSyntaxWrapper(VariableDesignationSyntaxWrapper node)
        {
            return (ParenthesizedVariableDesignationSyntaxWrapper)node.SyntaxNode;
        }

        public static implicit operator VariableDesignationSyntaxWrapper(ParenthesizedVariableDesignationSyntaxWrapper wrapper)
        {
            return VariableDesignationSyntaxWrapper.FromUpcast(wrapper.node);
        }

        public ParenthesizedVariableDesignationSyntaxWrapper AddVariables(params VariableDesignationSyntaxWrapper[] items)
        {
            return new ParenthesizedVariableDesignationSyntaxWrapper(this.WithVariables(this.Variables.AddRange(items)));
        }

        public ParenthesizedVariableDesignationSyntaxWrapper WithOpenParenToken(SyntaxToken identifier)
        {
            return new ParenthesizedVariableDesignationSyntaxWrapper(WithOpenParenTokenAccessor(this.SyntaxNode, identifier));
        }

        public ParenthesizedVariableDesignationSyntaxWrapper WithVariables(SeparatedSyntaxListWrapper<VariableDesignationSyntaxWrapper> variables)
        {
            return new ParenthesizedVariableDesignationSyntaxWrapper(WithVariablesAccessor(this.SyntaxNode, variables));
        }

        public ParenthesizedVariableDesignationSyntaxWrapper WithCloseParenToken(SyntaxToken identifier)
        {
            return new ParenthesizedVariableDesignationSyntaxWrapper(WithCloseParenTokenAccessor(this.SyntaxNode, identifier));
        }
    }
}
