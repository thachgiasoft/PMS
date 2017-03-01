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
	/// Represents the DataRepository.ReportTemplateProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ReportTemplateDataSourceDesigner))]
	public class ReportTemplateDataSource : ProviderDataSource<ReportTemplate, ReportTemplateKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportTemplateDataSource class.
		/// </summary>
		public ReportTemplateDataSource() : base(new ReportTemplateService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ReportTemplateDataSourceView used by the ReportTemplateDataSource.
		/// </summary>
		protected ReportTemplateDataSourceView ReportTemplateView
		{
			get { return ( View as ReportTemplateDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ReportTemplateDataSource control invokes to retrieve data.
		/// </summary>
		public ReportTemplateSelectMethod SelectMethod
		{
			get
			{
				ReportTemplateSelectMethod selectMethod = ReportTemplateSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ReportTemplateSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ReportTemplateDataSourceView class that is to be
		/// used by the ReportTemplateDataSource.
		/// </summary>
		/// <returns>An instance of the ReportTemplateDataSourceView class.</returns>
		protected override BaseDataSourceView<ReportTemplate, ReportTemplateKey> GetNewDataSourceView()
		{
			return new ReportTemplateDataSourceView(this, DefaultViewName);
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
	/// Supports the ReportTemplateDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ReportTemplateDataSourceView : ProviderDataSourceView<ReportTemplate, ReportTemplateKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ReportTemplateDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ReportTemplateDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ReportTemplateDataSourceView(ReportTemplateDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ReportTemplateDataSource ReportTemplateOwner
		{
			get { return Owner as ReportTemplateDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ReportTemplateSelectMethod SelectMethod
		{
			get { return ReportTemplateOwner.SelectMethod; }
			set { ReportTemplateOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ReportTemplateService ReportTemplateProvider
		{
			get { return Provider as ReportTemplateService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ReportTemplate> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ReportTemplate> results = null;
			ReportTemplate item;
			count = 0;
			
			System.String _reportId;
			System.Int32? _userId_nullable;

			switch ( SelectMethod )
			{
				case ReportTemplateSelectMethod.Get:
					ReportTemplateKey entityKey  = new ReportTemplateKey();
					entityKey.Load(values);
					item = ReportTemplateProvider.Get(entityKey);
					results = new TList<ReportTemplate>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ReportTemplateSelectMethod.GetAll:
                    results = ReportTemplateProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ReportTemplateSelectMethod.GetPaged:
					results = ReportTemplateProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ReportTemplateSelectMethod.Find:
					if ( FilterParameters != null )
						results = ReportTemplateProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ReportTemplateProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ReportTemplateSelectMethod.GetByReportId:
					_reportId = ( values["ReportId"] != null ) ? (System.String) EntityUtil.ChangeType(values["ReportId"], typeof(System.String)) : string.Empty;
					item = ReportTemplateProvider.GetByReportId(_reportId);
					results = new TList<ReportTemplate>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ReportTemplateSelectMethod.GetByUserId:
					_userId_nullable = (System.Int32?) EntityUtil.ChangeType(values["UserId"], typeof(System.Int32?));
					results = ReportTemplateProvider.GetByUserId(_userId_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == ReportTemplateSelectMethod.Get || SelectMethod == ReportTemplateSelectMethod.GetByReportId )
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
				ReportTemplate entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ReportTemplateProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ReportTemplate> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ReportTemplateProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ReportTemplateDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ReportTemplateDataSource class.
	/// </summary>
	public class ReportTemplateDataSourceDesigner : ProviderDataSourceDesigner<ReportTemplate, ReportTemplateKey>
	{
		/// <summary>
		/// Initializes a new instance of the ReportTemplateDataSourceDesigner class.
		/// </summary>
		public ReportTemplateDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ReportTemplateSelectMethod SelectMethod
		{
			get { return ((ReportTemplateDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ReportTemplateDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ReportTemplateDataSourceActionList

	/// <summary>
	/// Supports the ReportTemplateDataSourceDesigner class.
	/// </summary>
	internal class ReportTemplateDataSourceActionList : DesignerActionList
	{
		private ReportTemplateDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ReportTemplateDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ReportTemplateDataSourceActionList(ReportTemplateDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ReportTemplateSelectMethod SelectMethod
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

	#endregion ReportTemplateDataSourceActionList
	
	#endregion ReportTemplateDataSourceDesigner
	
	#region ReportTemplateSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ReportTemplateDataSource.SelectMethod property.
	/// </summary>
	public enum ReportTemplateSelectMethod
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
		/// Represents the GetByReportId method.
		/// </summary>
		GetByReportId,
		/// <summary>
		/// Represents the GetByUserId method.
		/// </summary>
		GetByUserId
	}
	
	#endregion ReportTemplateSelectMethod

	#region ReportTemplateFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportTemplateFilter : SqlFilter<ReportTemplateColumn>
	{
	}
	
	#endregion ReportTemplateFilter

	#region ReportTemplateExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportTemplateExpressionBuilder : SqlExpressionBuilder<ReportTemplateColumn>
	{
	}
	
	#endregion ReportTemplateExpressionBuilder	

	#region ReportTemplateProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ReportTemplateChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ReportTemplate"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ReportTemplateProperty : ChildEntityProperty<ReportTemplateChildEntityTypes>
	{
	}
	
	#endregion ReportTemplateProperty
}

