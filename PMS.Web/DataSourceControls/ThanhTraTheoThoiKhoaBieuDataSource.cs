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
	/// Represents the DataRepository.ThanhTraTheoThoiKhoaBieuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThanhTraTheoThoiKhoaBieuDataSourceDesigner))]
	public class ThanhTraTheoThoiKhoaBieuDataSource : ProviderDataSource<ThanhTraTheoThoiKhoaBieu, ThanhTraTheoThoiKhoaBieuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuDataSource class.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuDataSource() : base(new ThanhTraTheoThoiKhoaBieuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThanhTraTheoThoiKhoaBieuDataSourceView used by the ThanhTraTheoThoiKhoaBieuDataSource.
		/// </summary>
		protected ThanhTraTheoThoiKhoaBieuDataSourceView ThanhTraTheoThoiKhoaBieuView
		{
			get { return ( View as ThanhTraTheoThoiKhoaBieuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThanhTraTheoThoiKhoaBieuDataSource control invokes to retrieve data.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get
			{
				ThanhTraTheoThoiKhoaBieuSelectMethod selectMethod = ThanhTraTheoThoiKhoaBieuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThanhTraTheoThoiKhoaBieuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThanhTraTheoThoiKhoaBieuDataSourceView class that is to be
		/// used by the ThanhTraTheoThoiKhoaBieuDataSource.
		/// </summary>
		/// <returns>An instance of the ThanhTraTheoThoiKhoaBieuDataSourceView class.</returns>
		protected override BaseDataSourceView<ThanhTraTheoThoiKhoaBieu, ThanhTraTheoThoiKhoaBieuKey> GetNewDataSourceView()
		{
			return new ThanhTraTheoThoiKhoaBieuDataSourceView(this, DefaultViewName);
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
	/// Supports the ThanhTraTheoThoiKhoaBieuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThanhTraTheoThoiKhoaBieuDataSourceView : ProviderDataSourceView<ThanhTraTheoThoiKhoaBieu, ThanhTraTheoThoiKhoaBieuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThanhTraTheoThoiKhoaBieuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThanhTraTheoThoiKhoaBieuDataSourceView(ThanhTraTheoThoiKhoaBieuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThanhTraTheoThoiKhoaBieuDataSource ThanhTraTheoThoiKhoaBieuOwner
		{
			get { return Owner as ThanhTraTheoThoiKhoaBieuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ThanhTraTheoThoiKhoaBieuOwner.SelectMethod; }
			set { ThanhTraTheoThoiKhoaBieuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThanhTraTheoThoiKhoaBieuService ThanhTraTheoThoiKhoaBieuProvider
		{
			get { return Provider as ThanhTraTheoThoiKhoaBieuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThanhTraTheoThoiKhoaBieu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThanhTraTheoThoiKhoaBieu> results = null;
			ThanhTraTheoThoiKhoaBieu item;
			count = 0;
			
			System.Int32 _maLichHoc;
			System.String _maCanBoGiangDay;

			switch ( SelectMethod )
			{
				case ThanhTraTheoThoiKhoaBieuSelectMethod.Get:
					ThanhTraTheoThoiKhoaBieuKey entityKey  = new ThanhTraTheoThoiKhoaBieuKey();
					entityKey.Load(values);
					item = ThanhTraTheoThoiKhoaBieuProvider.Get(entityKey);
					results = new TList<ThanhTraTheoThoiKhoaBieu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThanhTraTheoThoiKhoaBieuSelectMethod.GetAll:
                    results = ThanhTraTheoThoiKhoaBieuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThanhTraTheoThoiKhoaBieuSelectMethod.GetPaged:
					results = ThanhTraTheoThoiKhoaBieuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThanhTraTheoThoiKhoaBieuSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThanhTraTheoThoiKhoaBieuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThanhTraTheoThoiKhoaBieuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThanhTraTheoThoiKhoaBieuSelectMethod.GetByMaLichHocMaCanBoGiangDay:
					_maLichHoc = ( values["MaLichHoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaLichHoc"], typeof(System.Int32)) : (int)0;
					_maCanBoGiangDay = ( values["MaCanBoGiangDay"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaCanBoGiangDay"], typeof(System.String)) : string.Empty;
					item = ThanhTraTheoThoiKhoaBieuProvider.GetByMaLichHocMaCanBoGiangDay(_maLichHoc, _maCanBoGiangDay);
					results = new TList<ThanhTraTheoThoiKhoaBieu>();
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
			if ( SelectMethod == ThanhTraTheoThoiKhoaBieuSelectMethod.Get || SelectMethod == ThanhTraTheoThoiKhoaBieuSelectMethod.GetByMaLichHocMaCanBoGiangDay )
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
				ThanhTraTheoThoiKhoaBieu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThanhTraTheoThoiKhoaBieuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThanhTraTheoThoiKhoaBieu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThanhTraTheoThoiKhoaBieuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThanhTraTheoThoiKhoaBieuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThanhTraTheoThoiKhoaBieuDataSource class.
	/// </summary>
	public class ThanhTraTheoThoiKhoaBieuDataSourceDesigner : ProviderDataSourceDesigner<ThanhTraTheoThoiKhoaBieu, ThanhTraTheoThoiKhoaBieuKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuDataSourceDesigner class.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
		{
			get { return ((ThanhTraTheoThoiKhoaBieuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThanhTraTheoThoiKhoaBieuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThanhTraTheoThoiKhoaBieuDataSourceActionList

	/// <summary>
	/// Supports the ThanhTraTheoThoiKhoaBieuDataSourceDesigner class.
	/// </summary>
	internal class ThanhTraTheoThoiKhoaBieuDataSourceActionList : DesignerActionList
	{
		private ThanhTraTheoThoiKhoaBieuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThanhTraTheoThoiKhoaBieuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThanhTraTheoThoiKhoaBieuDataSourceActionList(ThanhTraTheoThoiKhoaBieuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraTheoThoiKhoaBieuSelectMethod SelectMethod
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

	#endregion ThanhTraTheoThoiKhoaBieuDataSourceActionList
	
	#endregion ThanhTraTheoThoiKhoaBieuDataSourceDesigner
	
	#region ThanhTraTheoThoiKhoaBieuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThanhTraTheoThoiKhoaBieuDataSource.SelectMethod property.
	/// </summary>
	public enum ThanhTraTheoThoiKhoaBieuSelectMethod
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
		/// Represents the GetByMaLichHocMaCanBoGiangDay method.
		/// </summary>
		GetByMaLichHocMaCanBoGiangDay
	}
	
	#endregion ThanhTraTheoThoiKhoaBieuSelectMethod

	#region ThanhTraTheoThoiKhoaBieuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraTheoThoiKhoaBieuFilter : SqlFilter<ThanhTraTheoThoiKhoaBieuColumn>
	{
	}
	
	#endregion ThanhTraTheoThoiKhoaBieuFilter

	#region ThanhTraTheoThoiKhoaBieuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraTheoThoiKhoaBieuExpressionBuilder : SqlExpressionBuilder<ThanhTraTheoThoiKhoaBieuColumn>
	{
	}
	
	#endregion ThanhTraTheoThoiKhoaBieuExpressionBuilder	

	#region ThanhTraTheoThoiKhoaBieuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThanhTraTheoThoiKhoaBieuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraTheoThoiKhoaBieu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraTheoThoiKhoaBieuProperty : ChildEntityProperty<ThanhTraTheoThoiKhoaBieuChildEntityTypes>
	{
	}
	
	#endregion ThanhTraTheoThoiKhoaBieuProperty
}

