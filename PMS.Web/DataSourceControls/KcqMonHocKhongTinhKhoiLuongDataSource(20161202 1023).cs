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
	/// Represents the DataRepository.KcqMonHocKhongTinhKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqMonHocKhongTinhKhoiLuongDataSourceDesigner))]
	public class KcqMonHocKhongTinhKhoiLuongDataSource : ProviderDataSource<KcqMonHocKhongTinhKhoiLuong, KcqMonHocKhongTinhKhoiLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongDataSource class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongDataSource() : base(new KcqMonHocKhongTinhKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqMonHocKhongTinhKhoiLuongDataSourceView used by the KcqMonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		protected KcqMonHocKhongTinhKhoiLuongDataSourceView KcqMonHocKhongTinhKhoiLuongView
		{
			get { return ( View as KcqMonHocKhongTinhKhoiLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqMonHocKhongTinhKhoiLuongDataSource control invokes to retrieve data.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get
			{
				KcqMonHocKhongTinhKhoiLuongSelectMethod selectMethod = KcqMonHocKhongTinhKhoiLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqMonHocKhongTinhKhoiLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqMonHocKhongTinhKhoiLuongDataSourceView class that is to be
		/// used by the KcqMonHocKhongTinhKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the KcqMonHocKhongTinhKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqMonHocKhongTinhKhoiLuong, KcqMonHocKhongTinhKhoiLuongKey> GetNewDataSourceView()
		{
			return new KcqMonHocKhongTinhKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqMonHocKhongTinhKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqMonHocKhongTinhKhoiLuongDataSourceView : ProviderDataSourceView<KcqMonHocKhongTinhKhoiLuong, KcqMonHocKhongTinhKhoiLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqMonHocKhongTinhKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqMonHocKhongTinhKhoiLuongDataSourceView(KcqMonHocKhongTinhKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqMonHocKhongTinhKhoiLuongDataSource KcqMonHocKhongTinhKhoiLuongOwner
		{
			get { return Owner as KcqMonHocKhongTinhKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return KcqMonHocKhongTinhKhoiLuongOwner.SelectMethod; }
			set { KcqMonHocKhongTinhKhoiLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqMonHocKhongTinhKhoiLuongService KcqMonHocKhongTinhKhoiLuongProvider
		{
			get { return Provider as KcqMonHocKhongTinhKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqMonHocKhongTinhKhoiLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqMonHocKhongTinhKhoiLuong> results = null;
			KcqMonHocKhongTinhKhoiLuong item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2478_NamHoc;
			System.String sp2478_HocKy;

			switch ( SelectMethod )
			{
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.Get:
					KcqMonHocKhongTinhKhoiLuongKey entityKey  = new KcqMonHocKhongTinhKhoiLuongKey();
					entityKey.Load(values);
					item = KcqMonHocKhongTinhKhoiLuongProvider.Get(entityKey);
					results = new TList<KcqMonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.GetAll:
                    results = KcqMonHocKhongTinhKhoiLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.GetPaged:
					results = KcqMonHocKhongTinhKhoiLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqMonHocKhongTinhKhoiLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqMonHocKhongTinhKhoiLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqMonHocKhongTinhKhoiLuongProvider.GetById(_id);
					results = new TList<KcqMonHocKhongTinhKhoiLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqMonHocKhongTinhKhoiLuongSelectMethod.GetByNamHocHocKy:
					sp2478_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2478_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KcqMonHocKhongTinhKhoiLuongProvider.GetByNamHocHocKy(sp2478_NamHoc, sp2478_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KcqMonHocKhongTinhKhoiLuongSelectMethod.Get || SelectMethod == KcqMonHocKhongTinhKhoiLuongSelectMethod.GetById )
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
				KcqMonHocKhongTinhKhoiLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqMonHocKhongTinhKhoiLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqMonHocKhongTinhKhoiLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqMonHocKhongTinhKhoiLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqMonHocKhongTinhKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqMonHocKhongTinhKhoiLuongDataSource class.
	/// </summary>
	public class KcqMonHocKhongTinhKhoiLuongDataSourceDesigner : ProviderDataSourceDesigner<KcqMonHocKhongTinhKhoiLuong, KcqMonHocKhongTinhKhoiLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongDataSourceDesigner class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
		{
			get { return ((KcqMonHocKhongTinhKhoiLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqMonHocKhongTinhKhoiLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqMonHocKhongTinhKhoiLuongDataSourceActionList

	/// <summary>
	/// Supports the KcqMonHocKhongTinhKhoiLuongDataSourceDesigner class.
	/// </summary>
	internal class KcqMonHocKhongTinhKhoiLuongDataSourceActionList : DesignerActionList
	{
		private KcqMonHocKhongTinhKhoiLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqMonHocKhongTinhKhoiLuongDataSourceActionList(KcqMonHocKhongTinhKhoiLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongSelectMethod SelectMethod
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

	#endregion KcqMonHocKhongTinhKhoiLuongDataSourceActionList
	
	#endregion KcqMonHocKhongTinhKhoiLuongDataSourceDesigner
	
	#region KcqMonHocKhongTinhKhoiLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqMonHocKhongTinhKhoiLuongDataSource.SelectMethod property.
	/// </summary>
	public enum KcqMonHocKhongTinhKhoiLuongSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KcqMonHocKhongTinhKhoiLuongSelectMethod

	#region KcqMonHocKhongTinhKhoiLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonHocKhongTinhKhoiLuongFilter : SqlFilter<KcqMonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion KcqMonHocKhongTinhKhoiLuongFilter

	#region KcqMonHocKhongTinhKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonHocKhongTinhKhoiLuongExpressionBuilder : SqlExpressionBuilder<KcqMonHocKhongTinhKhoiLuongColumn>
	{
	}
	
	#endregion KcqMonHocKhongTinhKhoiLuongExpressionBuilder	

	#region KcqMonHocKhongTinhKhoiLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqMonHocKhongTinhKhoiLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonHocKhongTinhKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonHocKhongTinhKhoiLuongProperty : ChildEntityProperty<KcqMonHocKhongTinhKhoiLuongChildEntityTypes>
	{
	}
	
	#endregion KcqMonHocKhongTinhKhoiLuongProperty
}

