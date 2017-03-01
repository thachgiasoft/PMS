#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ReportManagermentsProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ReportManagermentsDataSourceDesigner))]
	public class ReportManagermentsDataSource : ProviderDataSource<ReportManagerments, ReportManagermentsKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsDataSource class.
		/// </summary>
		public ReportManagermentsDataSource() : base(new ReportManagermentsService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ReportManagermentsDataSourceView used by the ReportManagermentsDataSource.
		/// </summary>
		protected ReportManagermentsDataSourceView ReportManagermentsView
		{
			get { return ( View as ReportManagermentsDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ReportManagermentsDataSource control invokes to retrieve data.
		/// </summary>
		public ReportManagermentsSelectMethod SelectMethod
		{
			get
			{
				ReportManagermentsSelectMethod selectMethod = ReportManagermentsSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ReportManagermentsSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ReportManagermentsDataSourceView class that is to be
		/// used by the ReportManagermentsDataSource.
		/// </summary>
		/// <returns>An instance of the ReportManagermentsDataSourceView class.</returns>
		protected override BaseDataSourceView<ReportManagerments, ReportManagermentsKey> GetNewDataSourceView()
		{
			return new ReportManagermentsDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ReportManagermentsDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ReportManagermentsDataSourceView : ProviderDataSourceView<ReportManagerments, ReportManagermentsKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ReportManagermentsDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ReportManagermentsDataSourceView(ReportManagermentsDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ReportManagermentsDataSource ReportManagermentsOwner
		{
			get { return Owner as ReportManagermentsDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ReportManagermentsSelectMethod SelectMethod
		{
			get { return ReportManagermentsOwner.SelectMethod; }
			set { ReportManagermentsOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ReportManagermentsService ReportManagermentsProvider
		{
			get { return Provider as ReportManagermentsService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ReportManagerments> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ReportManagerments> results = null;
			ReportManagerments item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ReportManagermentsSelectMethod.Get:
					ReportManagermentsKey entityKey  = new ReportManagermentsKey();
					entityKey.Load(values);
					item = ReportManagermentsProvider.Get(entityKey);
					results = new TList<ReportManagerments>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ReportManagermentsSelectMethod.GetAll:
                    results = ReportManagermentsProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ReportManagermentsSelectMethod.GetPaged:
					results = ReportManagermentsProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ReportManagermentsSelectMethod.Find:
					if ( FilterParameters != null )
						results = ReportManagermentsProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ReportManagermentsProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ReportManagermentsSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ReportManagermentsProvider.GetById(_id);
					results = new TList<ReportManagerments>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == ReportManagermentsSelectMethod.Get || SelectMethod == ReportManagermentsSelectMethod.GetById )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				ReportManagerments entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ReportManagermentsProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<ReportManagerments> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ReportManagermentsProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ReportManagermentsDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ReportManagermentsDataSource class.
	/// </summary>
	public class ReportManagermentsDataSourceDesigner : ProviderDataSourceDesigner<ReportManagerments, ReportManagermentsKey>
	{
		/// <summary>
		/// Initializes a new instance of the ReportManagermentsDataSourceDesigner class.
		/// </summary>
		public ReportManagermentsDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ReportManagermentsSelectMethod SelectMethod
		{
			get { return ((ReportManagermentsDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new ReportManagermentsDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ReportManagermentsDataSourceActionList

	/// <summary>
	/// Supports the ReportManagermentsDataSourceDesigner class.
	/// </summary>
	internal class ReportManagermentsDataSourceActionList : DesignerActionList
	{
		private ReportManagermentsDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ReportManagermentsDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ReportManagermentsDataSourceActionList(ReportManagermentsDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ReportManagermentsSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion ReportManagermentsDataSourceActionList
	
	#endregion ReportManagermentsDataSourceDesigner
	
	#region ReportManagermentsSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ReportManagermentsDataSource.SelectMethod property.
	/// </summary>
	public enum ReportManagermentsSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion ReportManagermentsSelectMethod

	#region ReportManagermentsFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportManagermentsFilter : SqlFilter<ReportManagermentsColumn>
	{
	}
	
	#endregion ReportManagermentsFilter

	#region ReportManagermentsExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportManagermentsExpressionBuilder : SqlExpressionBuilder<ReportManagermentsColumn>
	{
	}
	
	#endregion ReportManagermentsExpressionBuilder	

	#region ReportManagermentsProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ReportManagermentsChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ReportManagerments"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportManagermentsProperty : ChildEntityProperty<ReportManagermentsChildEntityTypes>
	{
	}
	
	#endregion ReportManagermentsProperty
}

