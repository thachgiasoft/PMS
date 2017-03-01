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
	/// Represents the DataRepository.KhoiLuongCacCongViecKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongCacCongViecKhacDataSourceDesigner))]
	public class KhoiLuongCacCongViecKhacDataSource : ProviderDataSource<KhoiLuongCacCongViecKhac, KhoiLuongCacCongViecKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacDataSource class.
		/// </summary>
		public KhoiLuongCacCongViecKhacDataSource() : base(new KhoiLuongCacCongViecKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongCacCongViecKhacDataSourceView used by the KhoiLuongCacCongViecKhacDataSource.
		/// </summary>
		protected KhoiLuongCacCongViecKhacDataSourceView KhoiLuongCacCongViecKhacView
		{
			get { return ( View as KhoiLuongCacCongViecKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongCacCongViecKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongCacCongViecKhacSelectMethod selectMethod = KhoiLuongCacCongViecKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongCacCongViecKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongCacCongViecKhacDataSourceView class that is to be
		/// used by the KhoiLuongCacCongViecKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongCacCongViecKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongCacCongViecKhac, KhoiLuongCacCongViecKhacKey> GetNewDataSourceView()
		{
			return new KhoiLuongCacCongViecKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongCacCongViecKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongCacCongViecKhacDataSourceView : ProviderDataSourceView<KhoiLuongCacCongViecKhac, KhoiLuongCacCongViecKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongCacCongViecKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongCacCongViecKhacDataSourceView(KhoiLuongCacCongViecKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongCacCongViecKhacDataSource KhoiLuongCacCongViecKhacOwner
		{
			get { return Owner as KhoiLuongCacCongViecKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get { return KhoiLuongCacCongViecKhacOwner.SelectMethod; }
			set { KhoiLuongCacCongViecKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongCacCongViecKhacService KhoiLuongCacCongViecKhacProvider
		{
			get { return Provider as KhoiLuongCacCongViecKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongCacCongViecKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongCacCongViecKhac> results = null;
			KhoiLuongCacCongViecKhac item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 _maLoaiCongViec;

			switch ( SelectMethod )
			{
				case KhoiLuongCacCongViecKhacSelectMethod.Get:
					KhoiLuongCacCongViecKhacKey entityKey  = new KhoiLuongCacCongViecKhacKey();
					entityKey.Load(values);
					item = KhoiLuongCacCongViecKhacProvider.Get(entityKey);
					results = new TList<KhoiLuongCacCongViecKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongCacCongViecKhacSelectMethod.GetAll:
                    results = KhoiLuongCacCongViecKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongCacCongViecKhacSelectMethod.GetPaged:
					results = KhoiLuongCacCongViecKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongCacCongViecKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongCacCongViecKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongCacCongViecKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongCacCongViecKhacSelectMethod.GetByIdMaLoaiCongViec:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					_maLoaiCongViec = ( values["MaLoaiCongViec"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaLoaiCongViec"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongCacCongViecKhacProvider.GetByIdMaLoaiCongViec(_id, _maLoaiCongViec);
					results = new TList<KhoiLuongCacCongViecKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongCacCongViecKhacSelectMethod.GetByMaLoaiCongViec:
					_maLoaiCongViec = ( values["MaLoaiCongViec"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaLoaiCongViec"], typeof(System.Int32)) : (int)0;
					results = KhoiLuongCacCongViecKhacProvider.GetByMaLoaiCongViec(_maLoaiCongViec, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KhoiLuongCacCongViecKhacSelectMethod.Get || SelectMethod == KhoiLuongCacCongViecKhacSelectMethod.GetByIdMaLoaiCongViec )
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
				KhoiLuongCacCongViecKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongCacCongViecKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongCacCongViecKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongCacCongViecKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongCacCongViecKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongCacCongViecKhacDataSource class.
	/// </summary>
	public class KhoiLuongCacCongViecKhacDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongCacCongViecKhac, KhoiLuongCacCongViecKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacDataSourceDesigner class.
		/// </summary>
		public KhoiLuongCacCongViecKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get { return ((KhoiLuongCacCongViecKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongCacCongViecKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongCacCongViecKhacDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongCacCongViecKhacDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongCacCongViecKhacDataSourceActionList : DesignerActionList
	{
		private KhoiLuongCacCongViecKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongCacCongViecKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongCacCongViecKhacDataSourceActionList(KhoiLuongCacCongViecKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongCacCongViecKhacSelectMethod SelectMethod
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

	#endregion KhoiLuongCacCongViecKhacDataSourceActionList
	
	#endregion KhoiLuongCacCongViecKhacDataSourceDesigner
	
	#region KhoiLuongCacCongViecKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongCacCongViecKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongCacCongViecKhacSelectMethod
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
		/// Represents the GetByIdMaLoaiCongViec method.
		/// </summary>
		GetByIdMaLoaiCongViec,
		/// <summary>
		/// Represents the GetByMaLoaiCongViec method.
		/// </summary>
		GetByMaLoaiCongViec
	}
	
	#endregion KhoiLuongCacCongViecKhacSelectMethod

	#region KhoiLuongCacCongViecKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongCacCongViecKhacFilter : SqlFilter<KhoiLuongCacCongViecKhacColumn>
	{
	}
	
	#endregion KhoiLuongCacCongViecKhacFilter

	#region KhoiLuongCacCongViecKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongCacCongViecKhacExpressionBuilder : SqlExpressionBuilder<KhoiLuongCacCongViecKhacColumn>
	{
	}
	
	#endregion KhoiLuongCacCongViecKhacExpressionBuilder	

	#region KhoiLuongCacCongViecKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongCacCongViecKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongCacCongViecKhacProperty : ChildEntityProperty<KhoiLuongCacCongViecKhacChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongCacCongViecKhacProperty
}

