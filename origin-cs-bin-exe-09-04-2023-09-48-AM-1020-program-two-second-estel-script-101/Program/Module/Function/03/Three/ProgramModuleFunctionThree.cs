using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
		{
			FormBinary[] formBinaryArray;

			formBinaryArray = FormBinary.FormBinaryDefaultSetSurface(module.Second.FileArray);

			Expression[] expressionArray;

			expressionArray = Expression.ExpressionDefaultSetSurface(formBinaryArray, module.First.WorkingDirectory);

			Expression expression;

			expression = Expression.MakeExpressionCombine(expressionArray);

            ProgramModuleFunctionThird third;

			third = new ProgramModuleFunctionThird(formBinaryArray, expressionArray, expression);

			module.Third = third;

			return module;
		}
	}
}