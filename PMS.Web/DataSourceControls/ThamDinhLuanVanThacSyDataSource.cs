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
	/// Represents the DataRepository.ThamDinhLuanVanThacSyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThamDinhLuanVanThacSyDataSourceDesigner))]
	public class ThamDinhLuanVanThacSyDataSource : ProviderDataSource<ThamDinhLuanVanThacSy, ThamDinhLuanVanThacSyKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThamDinhLuanVanThacSyDataSource class.
		/// </summary>
		public ThamDinhLuanVanThacSyDataSource() : base(new ThamDinhLuanVanThacSyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThamDinhLuanVanThacSyDataSourceView used by the ThamDinhLuanVanThacSyDataSource.
		/// </summary>
		protected ThamDinhLuanVanThacSyDataSourceView ThamDinhLuanVanThacSyView
		{
			get { return ( View as ThamDinhLuanVanThacSyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThamDinhLuanVanThacSyDataSource control invokes to retrieve data.
		/// </summary>
		public ThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get
			{
				ThamDinhLuanVanThacSySelectMethod selectMethod = ThamDinhLuanVanThacSySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThamDinhLuanVanThacSySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThamDinhLuanVanThacSyDataSourceView class that is to be
		/// used by the ThamDinhLuanVanThacSyDataSource.
		/// </summary>
		/// <returns>An instance of the ThamDinhLuanVanThacSyDataSourceView class.</returns>
		protected override BaseDataSourceView<ThamDinhLuanVanThacSy, ThamDinhLuanVanThacSyKey> GetNewDataSourceView()
		{
			return new ThamDinhLuanVanThacSyDataSourceView(this, DefaultViewName);
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
	/// Supports the ThamDinhLuanVanThacSyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThamDinhLuanVanThacSyDataSourceView : ProviderDataSourceView<ThamDinhLuanVanThacSy, ThamDinhLuanVanThacSyKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThamDinhLuanVanThacSyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThamDinhLuanVanThacSyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThamDinhLuanVanThacSyDataSourceView(ThamDinhLuanVanThacSyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThamDinhLuanVanThacSyDataSource ThamDinhLuanVanThacSyOwner
		{
			get { return Owner as ThamDinhLuanVanThacSyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get { return ThamDinhLuanVanThacSyOwner.SelectMethod; }
			set { ThamDinhLuanVanThacSyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThamDinhLuanVanThacSyService ThamDinhLuanVanThacSyProvider
		{
			get { return Provider as ThamDinhLuanVanThacSyService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThamDinhLuanVanThacSy> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThamDinhLuanVanThacSy> results = null;
			ThamDinhLuanVanThacSy item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case ThamDinhLuanVanThacSySelectMethod.Get:
					ThamDinhLuanVanThacSyKey entityKey  = new ThamDinhLuanVanThacSyKey();
					entityKey.Load(values);
					item = ThamDinhLuanVanThacSyProvider.Get(entityKey);
					results = new TList<ThamDinhLuanVanThacSy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThamDinhLuanVanThacSySelectMethod.GetAll:
                    results = ThamDinhLuanVanThacSyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThamDinhLuanVanThacSySelectMethod.GetPaged:
					results = ThamDinhLuanVanThacSyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThamDinhLuanVanThacSySelectMethod.Find:
					if ( FilterParameters != null )
						results = ThamDinhLuanVanThacSyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThamDinhLuanVanThacSyProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThamDinhLuanVanThacSySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThamDinhLuanVanThacSyProvider.GetById(_id);
					results = new TList<ThamDinhLuanVanThacSy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ThamDinhLuanVanThacSySelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = ThamDinhLuanVanThacSyProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == ThamDinhLuanVanThacSySelectMethod.Get || SelectMethod == ThamDinhLuanVanThacSySelectMethod.GetById )
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
				ThamDinhLuanVanThacSy entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThamDinhLuanVanThacSyProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThamDinhLuanVanThacSy> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThamDinhLuanVanThacSyProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThamDinhLuanVanThacSyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThamDinhLuanVanThacSyDataSource class.
	/// </summary>
	public class ThamDinhLuanVanThacSyDataSourceDesigner : ProviderDataSourceDesigner<ThamDinhLuanVanThacSy, ThamDinhLuanVanThacSyKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThamDinhLuanVanThacSyDataSourceDesigner class.
		/// </summary>
		public ThamDinhLuanVanThacSyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThamDinhLuanVanThacSySelectMethod SelectMethod
		{
			get { return ((ThamDinhLuanVanThacSyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThamDinhLuanVanThacSyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThamDinhLuanVanThacSyDataSourceActionList

	/// <summary>
	/// Supports the ThamDinhLuanVanThacSyDataSourceDesigner class.
	/// </summary>
	internal class ThamDinhLuanVanThacSyDataSourceActionList : DesignerActionList
	{
		private ThamDinhLuanVanThacSyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThamDinhLuanVanThacSyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThamDinhLuanVanThacSyDataSourceActionList(ThamDinhLuanVanThacSyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThamDinhLuanVanThacSySelectMethod SelectMethod
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

	#endregion ThamDinhLuanVanThacSyDataSourceActionList
	
	#endregion ThamDinhLuanVanThacSyDataSourceDesigner
	
	#region ThamDinhLuanVanThacSySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThamDinhLuanVanThacSyDataSource.SelectMethod property.
	/// </summary>
	public enum ThamDinhLuanVanThacSySelectMethod
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
		GetById,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion ThamDinhLuanVanThacSySelectMethod

	#region ThamDinhLuanVanThacSyFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThamDinhLuanVanThacSy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThamDinhLuanVanThacSyFilter : SqlFilter<ThamDinhLuanVanThacSyColumn>
	{
	}
	
	#endregion ThamDinhLuanVanThacSyFilter

	#region ThamDinhLuanVanThacSyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThamDinhLuanVanThacSy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThamDinhLuanVanThacSyExpressionBuilder : SqlExpressionBuilder<ThamDinhLuanVanThacSyColumn>
	{
	}
	
	#endregion ThamDinhLuanVanThacSyExpressionBuilder	

	#region ThamDinhLuanVanThacSyProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThamDinhLuanVanThacSyChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThamDinhLuanVanThacSy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThamDinhLuanVanThacSyProperty : ChildEntityProperty<ThamDinhLuanVanThacSyChildEntityTypes>
	{
	}
	
	#endregion ThamDinhLuanVanThacSyProperty
}

