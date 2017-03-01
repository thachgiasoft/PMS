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
	/// Represents the DataRepository.NghienCuuKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NghienCuuKhoaHocDataSourceDesigner))]
	public class NghienCuuKhoaHocDataSource : ProviderDataSource<NghienCuuKhoaHoc, NghienCuuKhoaHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocDataSource class.
		/// </summary>
		public NghienCuuKhoaHocDataSource() : base(new NghienCuuKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NghienCuuKhoaHocDataSourceView used by the NghienCuuKhoaHocDataSource.
		/// </summary>
		protected NghienCuuKhoaHocDataSourceView NghienCuuKhoaHocView
		{
			get { return ( View as NghienCuuKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NghienCuuKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public NghienCuuKhoaHocSelectMethod SelectMethod
		{
			get
			{
				NghienCuuKhoaHocSelectMethod selectMethod = NghienCuuKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NghienCuuKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NghienCuuKhoaHocDataSourceView class that is to be
		/// used by the NghienCuuKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the NghienCuuKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<NghienCuuKhoaHoc, NghienCuuKhoaHocKey> GetNewDataSourceView()
		{
			return new NghienCuuKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the NghienCuuKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NghienCuuKhoaHocDataSourceView : ProviderDataSourceView<NghienCuuKhoaHoc, NghienCuuKhoaHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NghienCuuKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NghienCuuKhoaHocDataSourceView(NghienCuuKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NghienCuuKhoaHocDataSource NghienCuuKhoaHocOwner
		{
			get { return Owner as NghienCuuKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return NghienCuuKhoaHocOwner.SelectMethod; }
			set { NghienCuuKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NghienCuuKhoaHocService NghienCuuKhoaHocProvider
		{
			get { return Provider as NghienCuuKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NghienCuuKhoaHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NghienCuuKhoaHoc> results = null;
			NghienCuuKhoaHoc item;
			count = 0;
			
			System.Int32 _maNghienCuuKhoaHoc;
			System.String sp2774_MaQuanLy;
			System.String sp2774_NamHoc;
			System.Int32 sp2773_MaGiangVien;
			System.String sp2773_NamHoc;

			switch ( SelectMethod )
			{
				case NghienCuuKhoaHocSelectMethod.Get:
					NghienCuuKhoaHocKey entityKey  = new NghienCuuKhoaHocKey();
					entityKey.Load(values);
					item = NghienCuuKhoaHocProvider.Get(entityKey);
					results = new TList<NghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NghienCuuKhoaHocSelectMethod.GetAll:
                    results = NghienCuuKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NghienCuuKhoaHocSelectMethod.GetPaged:
					results = NghienCuuKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NghienCuuKhoaHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = NghienCuuKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NghienCuuKhoaHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NghienCuuKhoaHocSelectMethod.GetByMaNghienCuuKhoaHoc:
					_maNghienCuuKhoaHoc = ( values["MaNghienCuuKhoaHoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNghienCuuKhoaHoc"], typeof(System.Int32)) : (int)0;
					item = NghienCuuKhoaHocProvider.GetByMaNghienCuuKhoaHoc(_maNghienCuuKhoaHoc);
					results = new TList<NghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case NghienCuuKhoaHocSelectMethod.GetByMaQuanLyNamHoc:
					sp2774_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					sp2774_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = NghienCuuKhoaHocProvider.GetByMaQuanLyNamHoc(sp2774_MaQuanLy, sp2774_NamHoc, StartIndex, PageSize);
					break;
				case NghienCuuKhoaHocSelectMethod.GetByMaGiangVienNamHoc:
					sp2773_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					sp2773_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = NghienCuuKhoaHocProvider.GetByMaGiangVienNamHoc(sp2773_MaGiangVien, sp2773_NamHoc, StartIndex, PageSize);
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
			if ( SelectMethod == NghienCuuKhoaHocSelectMethod.Get || SelectMethod == NghienCuuKhoaHocSelectMethod.GetByMaNghienCuuKhoaHoc )
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
				NghienCuuKhoaHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NghienCuuKhoaHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NghienCuuKhoaHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NghienCuuKhoaHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NghienCuuKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NghienCuuKhoaHocDataSource class.
	/// </summary>
	public class NghienCuuKhoaHocDataSourceDesigner : ProviderDataSourceDesigner<NghienCuuKhoaHoc, NghienCuuKhoaHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocDataSourceDesigner class.
		/// </summary>
		public NghienCuuKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ((NghienCuuKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NghienCuuKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NghienCuuKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the NghienCuuKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class NghienCuuKhoaHocDataSourceActionList : DesignerActionList
	{
		private NghienCuuKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NghienCuuKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NghienCuuKhoaHocDataSourceActionList(NghienCuuKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NghienCuuKhoaHocSelectMethod SelectMethod
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

	#endregion NghienCuuKhoaHocDataSourceActionList
	
	#endregion NghienCuuKhoaHocDataSourceDesigner
	
	#region NghienCuuKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NghienCuuKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum NghienCuuKhoaHocSelectMethod
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
		/// Represents the GetByMaNghienCuuKhoaHoc method.
		/// </summary>
		GetByMaNghienCuuKhoaHoc,
		/// <summary>
		/// Represents the GetByMaQuanLyNamHoc method.
		/// </summary>
		GetByMaQuanLyNamHoc,
		/// <summary>
		/// Represents the GetByMaGiangVienNamHoc method.
		/// </summary>
		GetByMaGiangVienNamHoc
	}
	
	#endregion NghienCuuKhoaHocSelectMethod

	#region NghienCuuKhoaHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocFilter : SqlFilter<NghienCuuKhoaHocColumn>
	{
	}
	
	#endregion NghienCuuKhoaHocFilter

	#region NghienCuuKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocExpressionBuilder : SqlExpressionBuilder<NghienCuuKhoaHocColumn>
	{
	}
	
	#endregion NghienCuuKhoaHocExpressionBuilder	

	#region NghienCuuKhoaHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NghienCuuKhoaHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NghienCuuKhoaHocProperty : ChildEntityProperty<NghienCuuKhoaHocChildEntityTypes>
	{
	}
	
	#endregion NghienCuuKhoaHocProperty
}

