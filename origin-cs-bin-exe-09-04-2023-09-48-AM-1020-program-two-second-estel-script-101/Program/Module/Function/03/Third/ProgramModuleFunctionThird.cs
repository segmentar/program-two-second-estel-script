using Core;

namespace Core
{
	using System;

	public partial class ProgramModuleFunctionThird
	{
		public FormBinary[] FormBinaryArray;

		public Expression[] ExpressionArray;

		public Expression Expression;

		public ProgramModuleFunctionThird(FormBinary[] formBinaryArray, Expression[] expressionArray, Expression expression)
		{
			this.FormBinaryArray = formBinaryArray;

			this.ExpressionArray = expressionArray;

			this.Expression = expression;

			return;
		}

		~ProgramModuleFunctionThird()
		{
			return;
		}
	}
}