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
	/// Represents the DataRepository.ChiTietKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChiTietKhoiLuongDataSourceDesigner))]
	public class ChiTietKhoiLuongDataSource : ProviderDataSource<ChiTietKhoiLuong, ChiTietKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongDataSource class.
		/// </summary>
		public ChiTietKhoiLuongDataSource() : base(new ChiTietKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChiTietKhoiLuongDataSourceView used by the ChiTietKhoiLuongDataSource.
		/// </summary>
		protected ChiTietKhoiLuongDataSourceView ChiTietKhoiLuongView
		{
			get { return ( View as ChiTietKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChiTietKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public ChiTietKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				ChiTietKhoiLuongSelectMethod selectMethod = ChiTietKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChiTietKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChiTietKhoiLuongDataSourceView class that is to be
		/// used by the ChiTietKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the ChiTietKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<ChiTietKhoiLuong, ChiTietKhoiLuongKey> GetNewDataSourceView()
		{
			return new ChiTietKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the ChiTietKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChiTietKhoiLuongDataSourceView : ProviderDataSourceView<ChiTietKhoiLuong, ChiTietKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChiTietKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChiTietKhoiLuongDataSourceView(ChiTietKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChiTietKhoiLuongDataSource ChiTietKhoiLuongOwner
		{
			get { return Owner as ChiTietKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChiTietKhoiLuongSelectMethod SelectMethod
		{
			get { return ChiTietKhoiLuongOwner.SelectMethod; }
			set { ChiTietKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChiTietKhoiLuongService ChiTietKhoiLuongProvider
		{
			get { return Provider as ChiTietKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChiTietKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChiTietKhoiLuong> results = null;
			ChiTietKhoiLuong item;
			count = 0;
			
			System.Int32 _maChiTiet;
			System.Int32? _maKhoiLuong_nullable;

			switch ( SelectMethod )
			{
				case ChiTietKhoiLuongSelectMethod.Get:
					ChiTietKhoiLuongKey entityKey  = new ChiTietKhoiLuongKey();
					entityKey.Load(values);
					item = ChiTietKhoiLuongProvider.Get(entityKey);
					results = new TList<ChiTietKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChiTietKhoiLuongSelectMethod.GetAll:
                    results = ChiTietKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChiTietKhoiLuongSelectMethod.GetPaged:
					results = ChiTietKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChiTietKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = ChiTietKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChiTietKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChiTietKhoiLuongSelectMethod.GetByMaChiTiet:
					_maChiTiet = ( values["MaChiTiet"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaChiTiet"], typeof(System.Int32)) : (int)0;
					item = ChiTietKhoiLuongProvider.GetByMaChiTiet(_maChiTiet);
					results = new TList<ChiTietKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ChiTietKhoiLuongSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32?));
					results = ChiTietKhoiLuongProvider.GetByMaKhoiLuong(_maKhoiLuong_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == ChiTietKhoiLuongSelectMethod.Get || SelectMethod == ChiTietKhoiLuongSelectMethod.GetByMaChiTiet )
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
				ChiTietKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChiTietKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChiTietKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChiTietKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChiTietKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChiTietKhoiLuongDataSource class.
	/// </summary>
	public class ChiTietKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<ChiTietKhoiLuong, ChiTietKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongDataSourceDesigner class.
		/// </summary>
		public ChiTietKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChiTietKhoiLuongSelectMethod SelectMethod
		{
			get { return ((ChiTietKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChiTietKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChiTietKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the ChiTietKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class ChiTietKhoiLuongDataSourceActionList : DesignerActionList
	{
		private ChiTietKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChiTietKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChiTietKhoiLuongDataSourceActionList(ChiTietKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChiTietKhoiLuongSelectMethod SelectMethod
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

	#endregion ChiTietKhoiLuongDataSourceActionList
	
	#endregion ChiTietKhoiLuongDataSourceDesigner
	
	#region ChiTietKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChiTietKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum ChiTietKhoiLuongSelectMethod
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
		/// Represents the GetByMaChiTiet method.
		/// </summary>
		GetByMaChiTiet,
		/// <summary>
		/// Represents the GetByMaKhoiLuong method.
		/// </summary>
		GetByMaKhoiLuong
	}
	
	#endregion ChiTietKhoiLuongSelectMethod

	#region ChiTietKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTietKhoiLuongFilter : SqlFilter<ChiTietKhoiLuongColumn>
	{
	}
	
	#endregion ChiTietKhoiLuongFilter

	#region ChiTietKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTietKhoiLuongExpressionBuilder : SqlExpressionBuilder<ChiTietKhoiLuongColumn>
	{
	}
	
	#endregion ChiTietKhoiLuongExpressionBuilder	

	#region ChiTietKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChiTietKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTietKhoiLuongProperty : ChildEntityProperty<ChiTietKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion ChiTietKhoiLuongProperty
}

