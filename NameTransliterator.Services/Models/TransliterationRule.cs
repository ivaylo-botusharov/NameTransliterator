﻿namespace NameTransliterator.Services.Models
{
    using System;

    public class TransliterationRule : IComparable<TransliterationRule>
    {
        public TransliterationRule()
        {
        }

        public TransliterationRule(string sourceExpression, string targetExpression, int executionOrder)
        {
            this.SourceExpression = sourceExpression;
            this.TargetExpression = targetExpression;
            this.ExecutionOrder = executionOrder;
        }

        public int Id { get; set; }

        public string SourceExpression { get; set; }

        public string TargetExpression { get; set; }

        public int ExecutionOrder { get; set; }

        public int CompareTo(TransliterationRule otherRule)
        {
            if (this.ExecutionOrder == otherRule.ExecutionOrder)
            {
                return (-1) * this.SourceExpression.Length.CompareTo(otherRule.SourceExpression.Length);
            }

            return this.ExecutionOrder.CompareTo(otherRule.ExecutionOrder);
        }
    }
}
