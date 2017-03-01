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
	/// Represents the DataRepository.ThanhTraCoiThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThanhTraCoiThiDataSourceDesigner))]
	public class ThanhTraCoiThiDataSource : ProviderDataSource<ThanhTraCoiThi, ThanhTraCoiThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiDataSource class.
		/// </summary>
		public ThanhTraCoiThiDataSource() : base(new ThanhTraCoiThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThanhTraCoiThiDataSourceView used by the ThanhTraCoiThiDataSource.
		/// </summary>
		protected ThanhTraCoiThiDataSourceView ThanhTraCoiThiView
		{
			get { return ( View as ThanhTraCoiThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThanhTraCoiThiDataSource control invokes to retrieve data.
		/// </summary>
		public ThanhTraCoiThiSelectMethod SelectMethod
		{
			get
			{
				ThanhTraCoiThiSelectMethod selectMethod = ThanhTraCoiThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThanhTraCoiThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThanhTraCoiThiDataSourceView class that is to be
		/// used by the ThanhTraCoiThiDataSource.
		/// </summary>
		/// <returns>An instance of the ThanhTraCoiThiDataSourceView class.</returns>
		protected override BaseDataSourceView<ThanhTraCoiThi, ThanhTraCoiThiKey> GetNewDataSourceView()
		{
			return new ThanhTraCoiThiDataSourceView(this, DefaultViewName);
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
	/// Supports the ThanhTraCoiThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThanhTraCoiThiDataSourceView : ProviderDataSourceView<ThanhTraCoiThi, ThanhTraCoiThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThanhTraCoiThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThanhTraCoiThiDataSourceView(ThanhTraCoiThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThanhTraCoiThiDataSource ThanhTraCoiThiOwner
		{
			get { return Owner as ThanhTraCoiThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThanhTraCoiThiSelectMethod SelectMethod
		{
			get { return ThanhTraCoiThiOwner.SelectMethod; }
			set { ThanhTraCoiThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThanhTraCoiThiService ThanhTraCoiThiProvider
		{
			get { return Provider as ThanhTraCoiThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThanhTraCoiThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThanhTraCoiThi> results = null;
			ThanhTraCoiThi item;
			count = 0;
			
			System.Int32 _examination;
			System.String _maCanBoCoiThi;

			switch ( SelectMethod )
			{
				case ThanhTraCoiThiSelectMethod.Get:
					ThanhTraCoiThiKey entityKey  = new ThanhTraCoiThiKey();
					entityKey.Load(values);
					item = ThanhTraCoiThiProvider.Get(entityKey);
					results = new TList<ThanhTraCoiThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThanhTraCoiThiSelectMethod.GetAll:
                    results = ThanhTraCoiThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThanhTraCoiThiSelectMethod.GetPaged:
					results = ThanhTraCoiThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThanhTraCoiThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThanhTraCoiThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThanhTraCoiThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThanhTraCoiThiSelectMethod.GetByExaminationMaCanBoCoiThi:
					_examination = ( values["Examination"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Examination"], typeof(System.Int32)) : (int)0;
					_maCanBoCoiThi = ( values["MaCanBoCoiThi"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaCanBoCoiThi"], typeof(System.String)) : string.Empty;
					item = ThanhTraCoiThiProvider.GetByExaminationMaCanBoCoiThi(_examination, _maCanBoCoiThi);
					results = new TList<ThanhTraCoiThi>();
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
			if ( SelectMethod == ThanhTraCoiThiSelectMethod.Get || SelectMethod == ThanhTraCoiThiSelectMethod.GetByExaminationMaCanBoCoiThi )
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
				ThanhTraCoiThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThanhTraCoiThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThanhTraCoiThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThanhTraCoiThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThanhTraCoiThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThanhTraCoiThiDataSource class.
	/// </summary>
	public class ThanhTraCoiThiDataSourceDesigner : ProviderDataSourceDesigner<ThanhTraCoiThi, ThanhTraCoiThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiDataSourceDesigner class.
		/// </summary>
		public ThanhTraCoiThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraCoiThiSelectMethod SelectMethod
		{
			get { return ((ThanhTraCoiThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThanhTraCoiThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThanhTraCoiThiDataSourceActionList

	/// <summary>
	/// Supports the ThanhTraCoiThiDataSourceDesigner class.
	/// </summary>
	internal class ThanhTraCoiThiDataSourceActionList : DesignerActionList
	{
		private ThanhTraCoiThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThanhTraCoiThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThanhTraCoiThiDataSourceActionList(ThanhTraCoiThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraCoiThiSelectMethod SelectMethod
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

	#endregion ThanhTraCoiThiDataSourceActionList
	
	#endregion ThanhTraCoiThiDataSourceDesigner
	
	#region ThanhTraCoiThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThanhTraCoiThiDataSource.SelectMethod property.
	/// </summary>
	public enum ThanhTraCoiThiSelectMethod
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
		/// Represents the GetByExaminationMaCanBoCoiThi method.
		/// </summary>
		GetByExaminationMaCanBoCoiThi
	}
	
	#endregion ThanhTraCoiThiSelectMethod

	#region ThanhTraCoiThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraCoiThiFilter : SqlFilter<ThanhTraCoiThiColumn>
	{
	}
	
	#endregion ThanhTraCoiThiFilter

	#region ThanhTraCoiThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraCoiThiExpressionBuilder : SqlExpressionBuilder<ThanhTraCoiThiColumn>
	{
	}
	
	#endregion ThanhTraCoiThiExpressionBuilder	

	#region ThanhTraCoiThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThanhTraCoiThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraCoiThiProperty : ChildEntityProperty<ThanhTraCoiThiChildEntityTypes>
	{
	}
	
	#endregion ThanhTraCoiThiProperty
}

