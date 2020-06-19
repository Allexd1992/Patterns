using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Builder
{
    class ConcretBuilder : IBuilder
    {
        private Product product = new Product();

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public ConcretBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }

        // Все этапы производства работают с одним и тем же экземпляром
        // продукта.
        public void BuildStepA()
        {
            this.product.Add("PartA1");
        }

        public void BuildStepB()
        {
            this.product.Add("PartB1");
        }

        public void BuildStepC()
        {
            this.product.Add("PartC1");
        }

        // Конкретные Строители должны предоставить свои собственные методы
        // получения результатов. Это связано с тем, что различные типы
        // строителей могут создавать совершенно разные продукты с разными
        // интерфейсами. Поэтому такие методы не могут быть объявлены в базовом
        // интерфейсе Строителя (по крайней мере, в статически типизированном
        // языке программирования).
        //
        // Как правило, после возвращения конечного результата клиенту,
        // экземпляр строителя должен быть готов к началу производства
        // следующего продукта. Поэтому обычной практикой является вызов метода
        // сброса в конце тела метода GetProduct. Однако такое поведение не
        // является обязательным, вы можете заставить своих строителей ждать
        // явного запроса на сброс из кода клиента, прежде чем избавиться от
        // предыдущего результата.
        public Product GetProduct()
        {
            Product result = this.product;

            this.Reset();

            return result;
        }
    }
}
