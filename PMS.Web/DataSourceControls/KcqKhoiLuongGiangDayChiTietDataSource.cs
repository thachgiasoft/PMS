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
	/// Represents the DataRepository.KcqKhoiLuongGiangDayChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongGiangDayChiTietDataSourceDesigner))]
	public class KcqKhoiLuongGiangDayChiTietDataSource : ProviderDataSource<KcqKhoiLuongGiangDayChiTiet, KcqKhoiLuongGiangDayChiTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietDataSource class.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietDataSource() : base(new KcqKhoiLuongGiangDayChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongGiangDayChiTietDataSourceView used by the KcqKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		protected KcqKhoiLuongGiangDayChiTietDataSourceView KcqKhoiLuongGiangDayChiTietView
		{
			get { return ( View as KcqKhoiLuongGiangDayChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongGiangDayChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongGiangDayChiTietSelectMethod selectMethod = KcqKhoiLuongGiangDayChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongGiangDayChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongGiangDayChiTietDataSourceView class that is to be
		/// used by the KcqKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongGiangDayChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongGiangDayChiTiet, KcqKhoiLuongGiangDayChiTietKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongGiangDayChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongGiangDayChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongGiangDayChiTietDataSourceView : ProviderDataSourceView<KcqKhoiLuongGiangDayChiTiet, KcqKhoiLuongGiangDayChiTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongGiangDayChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongGiangDayChiTietDataSourceView(KcqKhoiLuongGiangDayChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongGiangDayChiTietDataSource KcqKhoiLuongGiangDayChiTietOwner
		{
			get { return Owner as KcqKhoiLuongGiangDayChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongGiangDayChiTietOwner.SelectMethod; }
			set { KcqKhoiLuongGiangDayChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongGiangDayChiTietService KcqKhoiLuongGiangDayChiTietProvider
		{
			get { return Provider as KcqKhoiLuongGiangDayChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongGiangDayChiTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongGiangDayChiTiet> results = null;
			KcqKhoiLuongGiangDayChiTiet item;
			count = 0;
			
			System.Int32 _maKhoiLuong;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongGiangDayChiTietSelectMethod.Get:
					KcqKhoiLuongGiangDayChiTietKey entityKey  = new KcqKhoiLuongGiangDayChiTietKey();
					entityKey.Load(values);
					item = KcqKhoiLuongGiangDayChiTietProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongGiangDayChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongGiangDayChiTietSelectMethod.GetAll:
                    results = KcqKhoiLuongGiangDayChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongGiangDayChiTietSelectMethod.GetPaged:
					results = KcqKhoiLuongGiangDayChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongGiangDayChiTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongGiangDayChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongGiangDayChiTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongGiangDayChiTietSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongGiangDayChiTietProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KcqKhoiLuongGiangDayChiTiet>();
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
			if ( SelectMethod == KcqKhoiLuongGiangDayChiTietSelectMethod.Get || SelectMethod == KcqKhoiLuongGiangDayChiTietSelectMethod.GetByMaKhoiLuong )
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
				KcqKhoiLuongGiangDayChiTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongGiangDayChiTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongGiangDayChiTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongGiangDayChiTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongGiangDayChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongGiangDayChiTietDataSource class.
	/// </summary>
	public class KcqKhoiLuongGiangDayChiTietDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongGiangDayChiTiet, KcqKhoiLuongGiangDayChiTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongGiangDayChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongGiangDayChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongGiangDayChiTietDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongGiangDayChiTietDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongGiangDayChiTietDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongGiangDayChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongGiangDayChiTietDataSourceActionList(KcqKhoiLuongGiangDayChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayChiTietSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongGiangDayChiTietDataSourceActionList
	
	#endregion KcqKhoiLuongGiangDayChiTietDataSourceDesigner
	
	#region KcqKhoiLuongGiangDayChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongGiangDayChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongGiangDayChiTietSelectMethod
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
		/// Represents the GetByMaKhoiLuong method.
		/// </summary>
		GetByMaKhoiLuong
	}
	
	#endregion KcqKhoiLuongGiangDayChiTietSelectMethod

	#region KcqKhoiLuongGiangDayChiTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayChiTietFilter : SqlFilter<KcqKhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayChiTietFilter

	#region KcqKhoiLuongGiangDayChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayChiTietExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayChiTietExpressionBuilder	

	#region KcqKhoiLuongGiangDayChiTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongGiangDayChiTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayChiTietProperty : ChildEntityProperty<KcqKhoiLuongGiangDayChiTietChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayChiTietProperty
}

