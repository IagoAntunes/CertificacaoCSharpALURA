using System;
using System.Linq.Expressions;

namespace Programa04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<float, float> metade = quo => quo / 2;
            Console.WriteLine("Metade de 9 é {0}", metade(9));

            //TAREFA: Recriar a Função acima, 
            //porém usando árvore de expressões LINQ

            //1) Criar as expressoes individuais
            ParameterExpression quociente
                = Expression.Parameter(typeof(float), "quo");

            ConstantExpression divisor
                = Expression.Constant(2f,typeof(float));

            BinaryExpression opDivisao 
                = Expression.Divide(quociente,divisor);
            //2)Criar uma arvore de expressoes
            Expression<Func<float, float>> exprMetade
                = Expression.Lambda<Func<float, float>>(opDivisao,
                new ParameterExpression[] {quociente});

            //3)Compilar e executar o codigo
            var metadeCompilada = exprMetade.Compile();
            Console.WriteLine("MetadeCompilada de 15 é {0}", metadeCompilada(15));

            //4)Modificar a arvore de expressoes
            trocarDivisao troca = new trocarDivisao();
            Expression<Func<float, float>> exprDobro
                = (Expression<Func<float, float>>)troca.Modificar(exprMetade);
            var dobroCompilado = exprDobro.Compile();
            Console.WriteLine("DobroCompilado de 12 é {0}", dobroCompilado(12));

            Console.ReadLine();
        }
    }
    class trocarDivisao : ExpressionVisitor
    {
        public Expression Modificar(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            if(node.NodeType == ExpressionType.Divide)
            {
                return Expression.Multiply(node.Left,node.Right);
            }

            return base.VisitBinary(node);
        }
    }
}
/*04
 * Gerar codigo em tempo de execução usando expressoes CodeDOM e lambda
 * CodeDOM o metodo de objetos do gerador de codigo
 * criando codigo de namespace,classe e membros com CodeDOM
 * Montando uma arvore de expressoes programaticamente
 * Modificando e consumindo expressoes
 */