$(window).bind('load', function() {
    var globalData=[];
    var tabsData = toDataType(tabsDataRaw);
    var accordionData = toDataType(subCategoriesData);
    for(var i=0;i<tabsData.length;i++){
        $('.tabssection').append('<li '+ (i==currentCategoryIndex?' class="ui-tabs-selected"':'')+'><a href="#fragment-'+tabsData[i].value+'" data-tab-index="'+i+'" data-tab-id="'+tabsData[i].value+'"><span>'+tabsData[i].text+'</span></a></li>');
        var layout = $(getTabContentLayout(tabsData[i]));
        if(i==currentCategoryIndex){            
            addSubCategoryContent(accordionData,layout.find('#accordion-'+tabsData[i].value));            
        }      
        
        $('#container-1').append(layout);       
    
        $('#accordion-'+tabsData[i].value).accordion({
            active:parseInt(currentSubCategoryIndex),
             
           });
       
        $(".tabssection").find("a[data-tab-id='"+tabsData[i].value+"']").click(selectCategory);
        
    }
    $('#container-1 > ul').tabs({
        show:function(ui){            
           // var tabId =  parseInt($(ui.tab).attr("data-tab-id"));
          
        }
    });
    
});

function addSubCategoryContent(accordionData, layout){
    for(var i=0;i<accordionData.length;i++){
        var liItem = $('<li></li>')
        var aItem = $('<a href="#" data-accordion-index="'+i+'">'+accordionData[i].text+'</a>');
        var divItem = $('<div></div>');
        var content= $("#all-content");
        if(i==parseInt(currentSubCategoryIndex)){
          divItem.append($("#all-content").clone().html());
           $("#all-content").empty();
           
           
         }
        aItem.click(selectSubCategory);        
        liItem.append(aItem);
        liItem.append(divItem);
        layout.append(liItem);
        divItem.find(".km-detail-action-link").click(goToDetails);
    }

}

function goToDetails(ev){
    var url='ProductDetails.aspx?prod_id=';
    var prodId=$(this).attr('data-product-id');
    document.location=url+prodId;
}

function selectSubCategory(){
    var subCategoryIndex = $(this).attr("data-accordion-index");
    document.getElementById("frmMVP").action ='DefaultMvp.aspx?categoryIndex='+currentCategoryIndex+"&subCategoryIndex="+subCategoryIndex;
   //__doPostBack('scrippostback','');
    document.getElementById("frmMVP").submit();
}

function selectCategory(ev){
    var categoryIndex =  $(this).attr("data-tab-index");
    document.getElementById("frmMVP").action ='DefaultMvp.aspx?categoryIndex='+categoryIndex;
    document.getElementById("frmMVP").submit();
    //__doPostBack('scrippostback2','');
}
        
function getTabContentLayout(dataTabItem){
    var layout =  $("#tab-content").html();
    
    for(index in dataTabItem){
        layout=layout.replace(/{{[A-Za-z]+}}/g, function(match){
            var index =  match.replace("{{","").replace("}}","");
            return dataTabItem[index]
        });
    }    
    return layout;
}

function toDataType(data){
    var result= [];
    var rawItems = data.split("|");
    
    var rawValues =  rawItems[1].split(",");
    var rawText =  rawItems[0].split(",");
    
    for(var i=0; i<rawValues.length;i++){
        result.push({
            text:rawText[i],
            value:rawValues[i]
        });
    }
    return result;
}
