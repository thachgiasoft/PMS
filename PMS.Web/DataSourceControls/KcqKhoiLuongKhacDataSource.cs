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
	/// Represents the DataRepository.KcqKhoiLuongKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongKhacDataSourceDesigner))]
	public class KcqKhoiLuongKhacDataSource : ProviderDataSource<KcqKhoiLuongKhac, KcqKhoiLuongKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacDataSource class.
		/// </summary>
		public KcqKhoiLuongKhacDataSource() : base(new KcqKhoiLuongKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongKhacDataSourceView used by the KcqKhoiLuongKhacDataSource.
		/// </summary>
		protected KcqKhoiLuongKhacDataSourceView KcqKhoiLuongKhacView
		{
			get { return ( View as KcqKhoiLuongKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongKhacSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongKhacSelectMethod selectMethod = KcqKhoiLuongKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongKhacDataSourceView class that is to be
		/// used by the KcqKhoiLuongKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongKhac, KcqKhoiLuongKhacKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongKhacDataSourceView : ProviderDataSourceView<KcqKhoiLuongKhac, KcqKhoiLuongKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongKhacDataSourceView(KcqKhoiLuongKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongKhacDataSource KcqKhoiLuongKhacOwner
		{
			get { return Owner as KcqKhoiLuongKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongKhacOwner.SelectMethod; }
			set { KcqKhoiLuongKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongKhacService KcqKhoiLuongKhacProvider
		{
			get { return Provider as KcqKhoiLuongKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongKhac> results = null;
			KcqKhoiLuongKhac item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.Int32? _maGiangVien_nullable;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongKhacSelectMethod.Get:
					KcqKhoiLuongKhacKey entityKey  = new KcqKhoiLuongKhacKey();
					entityKey.Load(values);
					item = KcqKhoiLuongKhacProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongKhacSelectMethod.GetAll:
                    results = KcqKhoiLuongKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongKhacSelectMethod.GetPaged:
					results = KcqKhoiLuongKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongKhacSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongKhacProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KcqKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqKhoiLuongKhacSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = KcqKhoiLuongKhacProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KcqKhoiLuongKhacSelectMethod.Get || SelectMethod == KcqKhoiLuongKhacSelectMethod.GetByMaKhoiLuong )
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
				KcqKhoiLuongKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongKhacDataSource class.
	/// </summary>
	public class KcqKhoiLuongKhacDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongKhac, KcqKhoiLuongKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongKhacDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongKhacDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongKhacDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongKhacDataSourceActionList(KcqKhoiLuongKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongKhacSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongKhacDataSourceActionList
	
	#endregion KcqKhoiLuongKhacDataSourceDesigner
	
	#region KcqKhoiLuongKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongKhacSelectMethod
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
		GetByMaKhoiLuong,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion KcqKhoiLuongKhacSelectMethod

	#region KcqKhoiLuongKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongKhacFilter : SqlFilter<KcqKhoiLuongKhacColumn>
	{
	}
	
	#endregion KcqKhoiLuongKhacFilter

	#region KcqKhoiLuongKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongKhacExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongKhacColumn>
	{
	}
	
	#endregion KcqKhoiLuongKhacExpressionBuilder	

	#region KcqKhoiLuongKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongKhacProperty : ChildEntityProperty<KcqKhoiLuongKhacChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongKhacProperty
}

