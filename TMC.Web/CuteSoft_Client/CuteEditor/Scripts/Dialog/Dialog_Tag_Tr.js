var OxO2c38=["inp_width","inp_height","sel_align","sel_valign","inp_bgColor","inp_borderColor","inp_borderColorLight","inp_borderColorDark","inp_class","inp_id","inp_tooltip","value","bgColor","backgroundColor","style","id","borderColor","borderColorLight","borderColorDark","className","width","height","align","vAlign","title","[[ValidNumber]]","[[ValidID]]","","class","valign","onclick"];var inp_width=Window_GetElement(window,OxO2c38[0],true);var inp_height=Window_GetElement(window,OxO2c38[1],true);var sel_align=Window_GetElement(window,OxO2c38[2],true);var sel_valign=Window_GetElement(window,OxO2c38[3],true);var inp_bgColor=Window_GetElement(window,OxO2c38[4],true);var inp_borderColor=Window_GetElement(window,OxO2c38[5],true);var inp_borderColorLight=Window_GetElement(window,OxO2c38[6],true);var inp_borderColorDark=Window_GetElement(window,OxO2c38[7],true);var inp_class=Window_GetElement(window,OxO2c38[8],true);var inp_id=Window_GetElement(window,OxO2c38[9],true);var inp_tooltip=Window_GetElement(window,OxO2c38[10],true);SyncToView=function SyncToView_Tr(){inp_bgColor[OxO2c38[11]]=element.getAttribute(OxO2c38[12])||element[OxO2c38[14]][OxO2c38[13]];inp_id[OxO2c38[11]]=element.getAttribute(OxO2c38[15]);inp_bgColor[OxO2c38[14]][OxO2c38[13]]=inp_bgColor[OxO2c38[11]];inp_borderColor[OxO2c38[11]]=element.getAttribute(OxO2c38[16]);inp_borderColor[OxO2c38[14]][OxO2c38[13]]=inp_borderColor[OxO2c38[11]];inp_borderColorLight[OxO2c38[11]]=element.getAttribute(OxO2c38[17]);inp_borderColorLight[OxO2c38[14]][OxO2c38[13]]=inp_borderColorLight[OxO2c38[11]];inp_borderColorDark[OxO2c38[11]]=element.getAttribute(OxO2c38[18]);inp_borderColorDark[OxO2c38[14]][OxO2c38[13]]=inp_borderColorDark[OxO2c38[11]];inp_class[OxO2c38[11]]=element[OxO2c38[19]];inp_width[OxO2c38[11]]=element.getAttribute(OxO2c38[20])||element[OxO2c38[14]][OxO2c38[20]];inp_height[OxO2c38[11]]=element.getAttribute(OxO2c38[21])||element[OxO2c38[14]][OxO2c38[21]];sel_align[OxO2c38[11]]=element.getAttribute(OxO2c38[22]);sel_valign[OxO2c38[11]]=element.getAttribute(OxO2c38[23]);inp_tooltip[OxO2c38[11]]=element.getAttribute(OxO2c38[24]);} ;SyncTo=function SyncTo_Tr(element){if(inp_bgColor[OxO2c38[11]]){if(element[OxO2c38[14]][OxO2c38[13]]){element[OxO2c38[14]][OxO2c38[13]]=inp_bgColor[OxO2c38[11]];} else {element[OxO2c38[12]]=inp_bgColor[OxO2c38[11]];} ;} else {element.removeAttribute(OxO2c38[12]);} ;element[OxO2c38[16]]=inp_borderColor[OxO2c38[11]];element[OxO2c38[17]]=inp_borderColorLight[OxO2c38[11]];element[OxO2c38[18]]=inp_borderColorDark[OxO2c38[11]];element[OxO2c38[19]]=inp_class[OxO2c38[11]];if(element[OxO2c38[14]][OxO2c38[20]]||element[OxO2c38[14]][OxO2c38[21]]){try{element[OxO2c38[14]][OxO2c38[20]]=inp_width[OxO2c38[11]];element[OxO2c38[14]][OxO2c38[21]]=inp_height[OxO2c38[11]];} catch(er){alert(OxO2c38[25]);} ;} else {try{element[OxO2c38[20]]=inp_width[OxO2c38[11]];element[OxO2c38[21]]=inp_height[OxO2c38[11]];} catch(er){alert(OxO2c38[25]);} ;} ;var Ox375=/[^a-z\d]/i;if(Ox375.test(inp_id.value)){alert(OxO2c38[26]);return ;} ;element[OxO2c38[22]]=sel_align[OxO2c38[11]];element[OxO2c38[15]]=inp_id[OxO2c38[11]];element[OxO2c38[23]]=sel_valign[OxO2c38[11]];element[OxO2c38[24]]=inp_tooltip[OxO2c38[11]];if(element[OxO2c38[15]]==OxO2c38[27]){element.removeAttribute(OxO2c38[15]);} ;if(element[OxO2c38[12]]==OxO2c38[27]){element.removeAttribute(OxO2c38[12]);} ;if(element[OxO2c38[16]]==OxO2c38[27]){element.removeAttribute(OxO2c38[16]);} ;if(element[OxO2c38[17]]==OxO2c38[27]){element.removeAttribute(OxO2c38[17]);} ;if(element[OxO2c38[7]]==OxO2c38[27]){element.removeAttribute(OxO2c38[7]);} ;if(element[OxO2c38[19]]==OxO2c38[27]){element.removeAttribute(OxO2c38[19]);} ;if(element[OxO2c38[19]]==OxO2c38[27]){element.removeAttribute(OxO2c38[28]);} ;if(element[OxO2c38[22]]==OxO2c38[27]){element.removeAttribute(OxO2c38[22]);} ;if(element[OxO2c38[23]]==OxO2c38[27]){element.removeAttribute(OxO2c38[29]);} ;if(element[OxO2c38[24]]==OxO2c38[27]){element.removeAttribute(OxO2c38[24]);} ;if(element[OxO2c38[20]]==OxO2c38[27]){element.removeAttribute(OxO2c38[20]);} ;if(element[OxO2c38[21]]==OxO2c38[27]){element.removeAttribute(OxO2c38[21]);} ;} ;inp_borderColor[OxO2c38[30]]=function inp_borderColor_onclick(){SelectColor(inp_borderColor);} ;inp_bgColor[OxO2c38[30]]=function inp_bgColor_onclick(){SelectColor(inp_bgColor);} ;inp_borderColorLight[OxO2c38[30]]=function inp_borderColorLight_onclick(){SelectColor(inp_borderColorLight);} ;inp_borderColorDark[OxO2c38[30]]=function inp_borderColorDark_onclick(){SelectColor(inp_borderColorDark);} ;