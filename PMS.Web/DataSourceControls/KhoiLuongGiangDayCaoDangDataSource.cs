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
	/// Represents the DataRepository.KhoiLuongGiangDayCaoDangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayCaoDangDataSourceDesigner))]
	public class KhoiLuongGiangDayCaoDangDataSource : ProviderDataSource<KhoiLuongGiangDayCaoDang, KhoiLuongGiangDayCaoDangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangDataSource class.
		/// </summary>
		public KhoiLuongGiangDayCaoDangDataSource() : base(new KhoiLuongGiangDayCaoDangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayCaoDangDataSourceView used by the KhoiLuongGiangDayCaoDangDataSource.
		/// </summary>
		protected KhoiLuongGiangDayCaoDangDataSourceView KhoiLuongGiangDayCaoDangView
		{
			get { return ( View as KhoiLuongGiangDayCaoDangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayCaoDangDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDayCaoDangSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDayCaoDangSelectMethod selectMethod = KhoiLuongGiangDayCaoDangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDayCaoDangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayCaoDangDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayCaoDangDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayCaoDangDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDayCaoDang, KhoiLuongGiangDayCaoDangKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayCaoDangDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayCaoDangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayCaoDangDataSourceView : ProviderDataSourceView<KhoiLuongGiangDayCaoDang, KhoiLuongGiangDayCaoDangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayCaoDangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayCaoDangDataSourceView(KhoiLuongGiangDayCaoDangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayCaoDangDataSource KhoiLuongGiangDayCaoDangOwner
		{
			get { return Owner as KhoiLuongGiangDayCaoDangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDayCaoDangSelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayCaoDangOwner.SelectMethod; }
			set { KhoiLuongGiangDayCaoDangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayCaoDangService KhoiLuongGiangDayCaoDangProvider
		{
			get { return Provider as KhoiLuongGiangDayCaoDangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDayCaoDang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDayCaoDang> results = null;
			KhoiLuongGiangDayCaoDang item;
			count = 0;
			
			System.Int32 _maKhoiLuongCaoDang;
			System.Int32? _maCauHinhChotGio_nullable;
			System.String sp559_MaBoMon;
			System.Int32 sp559_MaCauHinhChotGio;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDayCaoDangSelectMethod.Get:
					KhoiLuongGiangDayCaoDangKey entityKey  = new KhoiLuongGiangDayCaoDangKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayCaoDangProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDayCaoDang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDayCaoDangSelectMethod.GetAll:
                    results = KhoiLuongGiangDayCaoDangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDayCaoDangSelectMethod.GetPaged:
					results = KhoiLuongGiangDayCaoDangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDayCaoDangSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayCaoDangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayCaoDangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDayCaoDangSelectMethod.GetByMaKhoiLuongCaoDang:
					_maKhoiLuongCaoDang = ( values["MaKhoiLuongCaoDang"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuongCaoDang"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayCaoDangProvider.GetByMaKhoiLuongCaoDang(_maKhoiLuongCaoDang);
					results = new TList<KhoiLuongGiangDayCaoDang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongGiangDayCaoDangSelectMethod.GetByMaCauHinhChotGio:
					_maCauHinhChotGio_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32?));
					results = KhoiLuongGiangDayCaoDangProvider.GetByMaCauHinhChotGio(_maCauHinhChotGio_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case KhoiLuongGiangDayCaoDangSelectMethod.GetByMaBoMonMaCauHinhChotGio:
					sp559_MaBoMon = (System.String) EntityUtil.ChangeType(values["MaBoMon"], typeof(System.String));
					sp559_MaCauHinhChotGio = (System.Int32) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32));
					results = KhoiLuongGiangDayCaoDangProvider.GetByMaBoMonMaCauHinhChotGio(sp559_MaBoMon, sp559_MaCauHinhChotGio, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongGiangDayCaoDangSelectMethod.Get || SelectMethod == KhoiLuongGiangDayCaoDangSelectMethod.GetByMaKhoiLuongCaoDang )
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
				KhoiLuongGiangDayCaoDang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayCaoDangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDayCaoDang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayCaoDangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayCaoDangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayCaoDangDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayCaoDangDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDayCaoDang, KhoiLuongGiangDayCaoDangKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayCaoDangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayCaoDangSelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayCaoDangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayCaoDangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayCaoDangDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayCaoDangDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayCaoDangDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayCaoDangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayCaoDangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayCaoDangDataSourceActionList(KhoiLuongGiangDayCaoDangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayCaoDangSelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayCaoDangDataSourceActionList
	
	#endregion KhoiLuongGiangDayCaoDangDataSourceDesigner
	
	#region KhoiLuongGiangDayCaoDangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayCaoDangDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDayCaoDangSelectMethod
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
		/// Represents the GetByMaKhoiLuongCaoDang method.
		/// </summary>
		GetByMaKhoiLuongCaoDang,
		/// <summary>
		/// Represents the GetByMaCauHinhChotGio method.
		/// </summary>
		GetByMaCauHinhChotGio,
		/// <summary>
		/// Represents the GetByMaBoMonMaCauHinhChotGio method.
		/// </summary>
		GetByMaBoMonMaCauHinhChotGio
	}
	
	#endregion KhoiLuongGiangDayCaoDangSelectMethod

	#region KhoiLuongGiangDayCaoDangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayCaoDangFilter : SqlFilter<KhoiLuongGiangDayCaoDangColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayCaoDangFilter

	#region KhoiLuongGiangDayCaoDangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayCaoDangExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayCaoDangColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayCaoDangExpressionBuilder	

	#region KhoiLuongGiangDayCaoDangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayCaoDangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayCaoDangProperty : ChildEntityProperty<KhoiLuongGiangDayCaoDangChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayCaoDangProperty
}

