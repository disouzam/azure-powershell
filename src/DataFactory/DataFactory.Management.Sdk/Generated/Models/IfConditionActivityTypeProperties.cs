// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// IfCondition activity properties.
    /// </summary>
    public partial class IfConditionActivityTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the IfConditionActivityTypeProperties class.
        /// </summary>
        public IfConditionActivityTypeProperties()
        {
            this.Expression = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IfConditionActivityTypeProperties class.
        /// </summary>

        /// <param name="expression">An expression that would evaluate to Boolean. This is used to determine the
        /// block of activities (ifTrueActivities or ifFalseActivities) that will be
        /// executed.
        /// </param>

        /// <param name="ifTrueActivities">List of activities to execute if expression is evaluated to true. This is
        /// an optional property and if not provided, the activity will exit without
        /// any action.
        /// </param>

        /// <param name="ifFalseActivities">List of activities to execute if expression is evaluated to false. This is
        /// an optional property and if not provided, the activity will exit without
        /// any action.
        /// </param>
        public IfConditionActivityTypeProperties(Expression expression, System.Collections.Generic.IList<Activity> ifTrueActivities = default(System.Collections.Generic.IList<Activity>), System.Collections.Generic.IList<Activity> ifFalseActivities = default(System.Collections.Generic.IList<Activity>))

        {
            this.Expression = expression;
            this.IfTrueActivities = ifTrueActivities;
            this.IfFalseActivities = ifFalseActivities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets an expression that would evaluate to Boolean. This is used to
        /// determine the block of activities (ifTrueActivities or ifFalseActivities)
        /// that will be executed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expression")]
        public Expression Expression {get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute if expression is evaluated to
        /// true. This is an optional property and if not provided, the activity will
        /// exit without any action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ifTrueActivities")]
        public System.Collections.Generic.IList<Activity> IfTrueActivities {get; set; }

        /// <summary>
        /// Gets or sets list of activities to execute if expression is evaluated to
        /// false. This is an optional property and if not provided, the activity will
        /// exit without any action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ifFalseActivities")]
        public System.Collections.Generic.IList<Activity> IfFalseActivities {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Expression == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Expression");
            }
            if (this.Expression != null)
            {
                this.Expression.Validate();
            }
            if (this.IfTrueActivities != null)
            {
                foreach (var element in this.IfTrueActivities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.IfFalseActivities != null)
            {
                foreach (var element in this.IfFalseActivities)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}