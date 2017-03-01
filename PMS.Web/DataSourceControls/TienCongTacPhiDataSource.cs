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
	/// Represents the DataRepository.TienCongTacPhiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TienCongTacPhiDataSourceDesigner))]
	public class TienCongTacPhiDataSource : ProviderDataSource<TienCongTacPhi, TienCongTacPhiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiDataSource class.
		/// </summary>
		public TienCongTacPhiDataSource() : base(new TienCongTacPhiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TienCongTacPhiDataSourceView used by the TienCongTacPhiDataSource.
		/// </summary>
		protected TienCongTacPhiDataSourceView TienCongTacPhiView
		{
			get { return ( View as TienCongTacPhiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TienCongTacPhiDataSource control invokes to retrieve data.
		/// </summary>
		public TienCongTacPhiSelectMethod SelectMethod
		{
			get
			{
				TienCongTacPhiSelectMethod selectMethod = TienCongTacPhiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TienCongTacPhiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TienCongTacPhiDataSourceView class that is to be
		/// used by the TienCongTacPhiDataSource.
		/// </summary>
		/// <returns>An instance of the TienCongTacPhiDataSourceView class.</returns>
		protected override BaseDataSourceView<TienCongTacPhi, TienCongTacPhiKey> GetNewDataSourceView()
		{
			return new TienCongTacPhiDataSourceView(this, DefaultViewName);
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
	/// Supports the TienCongTacPhiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TienCongTacPhiDataSourceView : ProviderDataSourceView<TienCongTacPhi, TienCongTacPhiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TienCongTacPhiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TienCongTacPhiDataSourceView(TienCongTacPhiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TienCongTacPhiDataSource TienCongTacPhiOwner
		{
			get { return Owner as TienCongTacPhiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TienCongTacPhiSelectMethod SelectMethod
		{
			get { return TienCongTacPhiOwner.SelectMethod; }
			set { TienCongTacPhiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TienCongTacPhiService TienCongTacPhiProvider
		{
			get { return Provider as TienCongTacPhiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TienCongTacPhi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TienCongTacPhi> results = null;
			TienCongTacPhi item;
			count = 0;
			
			System.String _maCoSo;
			System.String sp881_MaCoSo;

			switch ( SelectMethod )
			{
				case TienCongTacPhiSelectMethod.Get:
					TienCongTacPhiKey entityKey  = new TienCongTacPhiKey();
					entityKey.Load(values);
					item = TienCongTacPhiProvider.Get(entityKey);
					results = new TList<TienCongTacPhi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TienCongTacPhiSelectMethod.GetAll:
                    results = TienCongTacPhiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TienCongTacPhiSelectMethod.GetPaged:
					results = TienCongTacPhiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TienCongTacPhiSelectMethod.Find:
					if ( FilterParameters != null )
						results = TienCongTacPhiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TienCongTacPhiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TienCongTacPhiSelectMethod.GetByMaCoSo:
					_maCoSo = ( values["MaCoSo"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaCoSo"], typeof(System.String)) : string.Empty;
					item = TienCongTacPhiProvider.GetByMaCoSo(_maCoSo);
					results = new TList<TienCongTacPhi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case TienCongTacPhiSelectMethod.GetByCoSo:
					sp881_MaCoSo = (System.String) EntityUtil.ChangeType(values["MaCoSo"], typeof(System.String));
					results = TienCongTacPhiProvider.GetByCoSo(sp881_MaCoSo, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == TienCongTacPhiSelectMethod.Get || SelectMethod == TienCongTacPhiSelectMethod.GetByMaCoSo )
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
				TienCongTacPhi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TienCongTacPhiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TienCongTacPhi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TienCongTacPhiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TienCongTacPhiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TienCongTacPhiDataSource class.
	/// </summary>
	public class TienCongTacPhiDataSourceDesigner : ProviderDataSourceDesigner<TienCongTacPhi, TienCongTacPhiKey>
	{
		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiDataSourceDesigner class.
		/// </summary>
		public TienCongTacPhiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TienCongTacPhiSelectMethod SelectMethod
		{
			get { return ((TienCongTacPhiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TienCongTacPhiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TienCongTacPhiDataSourceActionList

	/// <summary>
	/// Supports the TienCongTacPhiDataSourceDesigner class.
	/// </summary>
	internal class TienCongTacPhiDataSourceActionList : DesignerActionList
	{
		private TienCongTacPhiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TienCongTacPhiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TienCongTacPhiDataSourceActionList(TienCongTacPhiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TienCongTacPhiSelectMethod SelectMethod
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

	#endregion TienCongTacPhiDataSourceActionList
	
	#endregion TienCongTacPhiDataSourceDesigner
	
	#region TienCongTacPhiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TienCongTacPhiDataSource.SelectMethod property.
	/// </summary>
	public enum TienCongTacPhiSelectMethod
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
		/// Represents the GetByMaCoSo method.
		/// </summary>
		GetByMaCoSo,
		/// <summary>
		/// Represents the GetByCoSo method.
		/// </summary>
		GetByCoSo
	}
	
	#endregion TienCongTacPhiSelectMethod

	#region TienCongTacPhiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TienCongTacPhiFilter : SqlFilter<TienCongTacPhiColumn>
	{
	}
	
	#endregion TienCongTacPhiFilter

	#region TienCongTacPhiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TienCongTacPhiExpressionBuilder : SqlExpressionBuilder<TienCongTacPhiColumn>
	{
	}
	
	#endregion TienCongTacPhiExpressionBuilder	

	#region TienCongTacPhiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TienCongTacPhiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TienCongTacPhi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TienCongTacPhiProperty : ChildEntityProperty<TienCongTacPhiChildEntityTypes>
	{
	}
	
	#endregion TienCongTacPhiProperty
}

