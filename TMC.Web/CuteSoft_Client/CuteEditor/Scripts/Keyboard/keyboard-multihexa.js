var OxO81f3=["0123456789ABCDEF","0000","all","getElementById","","|","fond","\x3Cimg src=\x22Load.ashx?type=image\x26file=multiclavier.gif\x22 width=404 height=152 border=\x220\x22\x3E\x3Cbr /\x3E","sign","car","simpledia","simple","majus","\x26nbsp;","double","minus","doubledia","kb-","kb+","Delete","Clear","Back","CapsLock","Enter","Shift","\x3C|\x3C","Space","\x3E|\x3E","clavscroll(-3)","clavscroll(3)","faire(\x22del\x22)","RAZ()","faire(\x22bck\x22)","bloq()","faire(\x22\x5Cn\x22)","haut()","faire(\x22ar\x22)","faire(\x22 \x22)","faire(\x22av\x22)","act","action","clav","clavier","masque","\x3Cimg src=\x22Load.ashx?type=image\x26file=1x1.gif\x22 width=404 height=152 border=\x220\x22 usemap=\x22#clavier\x22\x3E","\x3Cmap name=\x22clavier\x22\x3E","\x3Carea coords=\x22",",","\x22 href=\x22javascript:void(0)\x22 onClick=\x27javascript:ecrire(",")\x27\x3E","\x22 href=\x22javascript:void(0)\x22 onClick=\x27javascript:","\x27\x3E","\x22 href=\x27javascript:charger(","\x3C/map\x3E","length"," ","%0D%0A","av","ar","bck","del","\x3Cspan class=","\x3E","\x3C/span\x3E","\x3Cdiv id=\x22","\x22 \x3E","\x3C/div\x3E","left","style","px","top","innerHTML","act0","act1","langue=","cookie",";","langue","=","; ","expires="];var caps=0,lock=0,hexchars=OxO81f3[0],accent=OxO81f3[1],clavdeb=0;var clav= new Array();j=0;for(i in Maj){clav[j]=i;j++;} ;var ns6=((!document[OxO81f3[2]])&&(document[OxO81f3[3]]));var ie=document[OxO81f3[2]];var langue=getCk();if(langue==OxO81f3[4]){langue=clav[clavdeb];} ;CarMaj=Maj[langue].split(OxO81f3[5]);CarMin=Min[langue].split(OxO81f3[5]);var posClavierLeft=0,posClavierTop=0;if(ns6){posClavierLeft=0;posClavierTop=80;} else {if(ie){posClavierLeft=0;posClavierTop=80;} ;} ;tracer(OxO81f3[6],posClavierLeft,posClavierTop,OxO81f3[7],OxO81f3[8]);var posX= new Array(0,28,56,84,112,140,168,196,224,252,280,308,336,42,70,98,126,154,182,210,238,266,294,322,350,50,78,106,134,162,190,218,246,274,302,330,64,92,120,148,176,204,232,260,288,316,28,56,84,294,322,350);var posY= new Array(14,14,14,14,14,14,14,14,14,14,14,14,14,42,42,42,42,42,42,42,42,42,42,42,42,70,70,70,70,70,70,70,70,70,70,70,98,98,98,98,98,98,98,98,98,98,126,126,126,126,126,126);var nbTouches=52;for(i=0;i<nbTouches;i++){CarMaj[i]=((CarMaj[i]!=OxO81f3[1])?(fromhexby4tocar(CarMaj[i])):OxO81f3[4]);CarMin[i]=((CarMin[i]!=OxO81f3[1])?(fromhexby4tocar(CarMin[i])):OxO81f3[4]);if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);tracer(OxO81f3[9]+i,posClavierLeft+6+posX[i],posClavierTop+3+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO81f3[10]:OxO81f3[11]));tracer(OxO81f3[12]+i,posClavierLeft+15+posX[i],posClavierTop+1+posY[i],OxO81f3[13],OxO81f3[14]);tracer(OxO81f3[15]+i,posClavierLeft+3+posX[i],posClavierTop+9+posY[i],OxO81f3[13],OxO81f3[14]);} else {tracer(OxO81f3[9]+i,posClavierLeft+6+posX[i],posClavierTop+3+posY[i],OxO81f3[13],OxO81f3[11]);cecar=CarMin[i];tracer(OxO81f3[15]+i,posClavierLeft+3+posX[i],posClavierTop+9+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO81f3[16]:OxO81f3[14]));cecar=CarMaj[i];tracer(OxO81f3[12]+i,posClavierLeft+15+posX[i],posClavierTop+1+posY[i],cecar,((dia[hexa(cecar)]!=null)?OxO81f3[16]:OxO81f3[14]));} ;} ;var actC1= new Array(0,371,364,0,378,0,358,0,344,0,112,378);var actC2= new Array(0,0,14,42,42,70,70,98,98,126,126,126);var actC3= new Array(32,403,403,39,403,47,403,61,403,25,291,403);var actC4= new Array(11,11,39,67,67,95,95,123,123,151,151,151);var act= new Array(OxO81f3[17],OxO81f3[18],OxO81f3[19],OxO81f3[20],OxO81f3[21],OxO81f3[22],OxO81f3[23],OxO81f3[24],OxO81f3[24],OxO81f3[25],OxO81f3[26],OxO81f3[27]);var effet= new Array(OxO81f3[28],OxO81f3[29],OxO81f3[30],OxO81f3[31],OxO81f3[32],OxO81f3[33],OxO81f3[34],OxO81f3[35],OxO81f3[35],OxO81f3[36],OxO81f3[37],OxO81f3[38]);var nbActions=12;for(i=0;i<nbActions;i++){tracer(OxO81f3[39]+i,posClavierLeft+1+actC1[i],posClavierTop-1+actC2[i],act[i],OxO81f3[40]);} ;var clavC1= new Array(35,119,203,287);var clavC2= new Array(0,0,0,0);var clavC3= new Array(116,200,284,368);var clavC4= new Array(11,11,11,11);for(i=0;i<4;i++){tracer(OxO81f3[41]+i,posClavierLeft+5+clavC1[i],posClavierTop-1+clavC2[i],clav[i],OxO81f3[42]);} ;tracer(OxO81f3[43],posClavierLeft,posClavierTop,OxO81f3[44]);document.write(OxO81f3[45]);for(i=0;i<nbTouches;i++){document.write(OxO81f3[46]+posX[i]+OxO81f3[47]+posY[i]+OxO81f3[47]+(posX[i]+25)+OxO81f3[47]+(posY[i]+25)+OxO81f3[48]+i+OxO81f3[49]);} ;for(i=0;i<nbActions;i++){document.write(OxO81f3[46]+actC1[i]+OxO81f3[47]+actC2[i]+OxO81f3[47]+actC3[i]+OxO81f3[47]+actC4[i]+OxO81f3[50]+effet[i]+OxO81f3[51]);} ;for(i=0;i<4;i++){document.write(OxO81f3[46]+clavC1[i]+OxO81f3[47]+clavC2[i]+OxO81f3[47]+clavC3[i]+OxO81f3[47]+clavC4[i]+OxO81f3[52]+i+OxO81f3[49]);} ;document.write(OxO81f3[53]);function ecrire(i){txt=rechercher()+OxO81f3[5];subtxt=txt.split(OxO81f3[5]);ceci=(lock==1)?CarMaj[i]:((caps==1)?CarMaj[i]:CarMin[i]);if(test(ceci)){subtxt[0]+=cardia(ceci);distinguer(false);} else {if(dia[accent]!=null&&dia[hexa(ceci)]!=null){distinguer(false);accent=hexa(ceci);distinguer(true);} else {if(dia[accent]!=null){subtxt[0]+=fromhexby4tocar(accent)+ceci;distinguer(false);} else {if(dia[hexa(ceci)]!=null){accent=hexa(ceci);distinguer(true);} else {subtxt[0]+=ceci;} ;} ;} ;} ;txt=subtxt[0]+OxO81f3[5]+subtxt[1];afficher(txt);if(caps==1){caps=0;MinusMajus();} ;} ;function faire(Oxb01){txt=rechercher()+OxO81f3[5];subtxt=txt.split(OxO81f3[5]);l0=subtxt[0][OxO81f3[54]];l1=subtxt[1][OxO81f3[54]];c1=subtxt[0].substring(0,(l0-2));c2=subtxt[0].substring(0,(l0-1));c3=subtxt[1].substring(0,1);c4=subtxt[1].substring(0,2);c5=subtxt[0].substring((l0-2),l0);c6=subtxt[0].substring((l0-1),l0);c7=subtxt[1].substring(1,l1);c8=subtxt[1].substring(2,l1);if(dia[accent]!=null){if(Oxb01==OxO81f3[55]){Oxb01=fromhexby4tocar(accent);} ;distinguer(false);} ;switch(Oxb01){case (OxO81f3[57]):if(escape(c4)!=OxO81f3[56]){txt=subtxt[0]+c3+OxO81f3[5]+c7;} else {txt=subtxt[0]+c4+OxO81f3[5]+c8;} ;break ;;case (OxO81f3[58]):if(escape(c5)!=OxO81f3[56]){txt=c2+OxO81f3[5]+c6+subtxt[1];} else {txt=c1+OxO81f3[5]+c5+subtxt[1];} ;break ;;case (OxO81f3[59]):if(escape(c5)!=OxO81f3[56]){txt=c2+OxO81f3[5]+subtxt[1];} else {txt=c1+OxO81f3[5]+subtxt[1];} ;break ;;case (OxO81f3[60]):if(escape(c4)!=OxO81f3[56]){txt=subtxt[0]+OxO81f3[5]+c7;} else {txt=subtxt[0]+OxO81f3[5]+c8;} ;break ;;default:txt=subtxt[0]+Oxb01+OxO81f3[5]+subtxt[1];break ;;} ;afficher(txt);} ;function RAZ(){txt=OxO81f3[4];if(dia[accent]!=null){distinguer(false);} ;afficher(txt);} ;function haut(){caps=1;MinusMajus();} ;function bloq(){lock=(lock==1)?0:1;MinusMajus();} ;function tracer(Oxb06,Oxb07,haut,Oxb01,Oxb08){Oxb01=OxO81f3[61]+Oxb08+OxO81f3[62]+Oxb01+OxO81f3[63];document.write(OxO81f3[64]+Oxb06+OxO81f3[65]+Oxb01+OxO81f3[66]);if(ns6){document.getElementById(Oxb06)[OxO81f3[68]][OxO81f3[67]]=Oxb07+OxO81f3[69];document.getElementById(Oxb06)[OxO81f3[68]][OxO81f3[70]]=haut+OxO81f3[69];} else {if(ie){document.all(Oxb06)[OxO81f3[68]][OxO81f3[67]]=Oxb07;document.all(Oxb06)[OxO81f3[68]][OxO81f3[70]]=haut;} ;} ;} ;function retracer(Oxb06,Oxb01,Oxb08){Oxb01=OxO81f3[61]+Oxb08+OxO81f3[62]+Oxb01+OxO81f3[63];if(ns6){document.getElementById(Oxb06)[OxO81f3[71]]=Oxb01;} else {if(ie){doc=document.all(Oxb06);doc[OxO81f3[71]]=Oxb01;} ;} ;} ;function clavscroll(Ox27){clavdeb+=Ox27;if(clavdeb<0){clavdeb=0;} ;if(clavdeb>clav[OxO81f3[54]]-4){clavdeb=clav[OxO81f3[54]]-4;} ;for(i=clavdeb;i<clavdeb+4;i++){retracer(OxO81f3[41]+(i-clavdeb),clav[i],OxO81f3[42]);} ;if(clavdeb==0){retracer(OxO81f3[72],OxO81f3[13],OxO81f3[40]);} else {retracer(OxO81f3[72],act[0],OxO81f3[40]);} ;if(clavdeb==clav[OxO81f3[54]]-4){retracer(OxO81f3[73],OxO81f3[13],OxO81f3[40]);} else {retracer(OxO81f3[73],act[1],OxO81f3[40]);} ;} ;function charger(i){langue=clav[i+clavdeb];setCk(langue);accent=OxO81f3[1];CarMaj=Maj[langue].split(OxO81f3[5]);CarMin=Min[langue].split(OxO81f3[5]);for(i=0;i<nbTouches;i++){CarMaj[i]=((CarMaj[i]!=OxO81f3[1])?(fromhexby4tocar(CarMaj[i])):OxO81f3[4]);CarMin[i]=((CarMin[i]!=OxO81f3[1])?(fromhexby4tocar(CarMin[i])):OxO81f3[4]);if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);retracer(OxO81f3[9]+i,cecar,((dia[hexa(cecar)]!=null)?OxO81f3[10]:OxO81f3[11]));retracer(OxO81f3[15]+i,OxO81f3[13]);retracer(OxO81f3[12]+i,OxO81f3[13]);} else {retracer(OxO81f3[9]+i,OxO81f3[13]);cecar=CarMin[i];retracer(OxO81f3[15]+i,cecar,((dia[hexa(cecar)]!=null)?OxO81f3[16]:OxO81f3[14]));cecar=CarMaj[i];retracer(OxO81f3[12]+i,cecar,((dia[hexa(cecar)]!=null)?OxO81f3[16]:OxO81f3[14]));} ;} ;} ;function distinguer(Oxb0d){for(i=0;i<nbTouches;i++){if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);if(test(cecar)){retracer(OxO81f3[9]+i,Oxb0d?(cardia(cecar)):cecar,Oxb0d?OxO81f3[10]:OxO81f3[11]);} ;} else {cecar=CarMin[i];if(test(cecar)){retracer(OxO81f3[15]+i,Oxb0d?(cardia(cecar)):cecar,Oxb0d?OxO81f3[16]:OxO81f3[14]);} ;cecar=CarMaj[i];if(test(cecar)){retracer(OxO81f3[12]+i,Oxb0d?(cardia(cecar)):cecar,Oxb0d?OxO81f3[16]:OxO81f3[14]);} ;} ;} ;if(!Oxb0d){accent=OxO81f3[1];} ;} ;function MinusMajus(){for(i=0;i<nbTouches;i++){if(CarMaj[i]==CarMin[i].toUpperCase()){cecar=((lock==0)&&(caps==0)?CarMin[i]:CarMaj[i]);retracer(OxO81f3[9]+i,(test(cecar)?cardia(cecar):cecar),((dia[hexa(cecar)]!=null||test(cecar))?OxO81f3[10]:OxO81f3[11]));} ;} ;} ;function test(Oxb0f){return (dia[accent]!=null&&dia[accent][hexa(Oxb0f)]!=null);} ;function cardia(Oxb0f){return (fromhexby4tocar(dia[accent][hexa(Oxb0f)]));} ;function fromhex(Oxb12){out=0;for(a=Oxb12[OxO81f3[54]]-1;a>=0;a--){out+=Math.pow(16,Oxb12[OxO81f3[54]]-a-1)*hexchars.indexOf(Oxb12.charAt(a));} ;return out;} ;function fromhexby4tocar(Oxb01){out4= new String();for(l=0;l<Oxb01[OxO81f3[54]];l+=4){out4+=String.fromCharCode(fromhex(Oxb01.substring(l,l+4)));} ;return out4;} ;function tohex(Oxb12){return hexchars.charAt(Oxb12/16)+hexchars.charAt(Oxb12%16);} ;function tohex2(Oxb12){return tohex(Oxb12/256)+tohex(Oxb12%256);} ;function hexa(Oxb01){out=OxO81f3[4];for(k=0;k<Oxb01[OxO81f3[54]];k++){out+=(tohex2(Oxb01.charCodeAt(k)));} ;return out;} ;function getCk(){fromN=document[OxO81f3[75]].indexOf(OxO81f3[74])+0;if((fromN)!=-1){fromN+=7;toN=document[OxO81f3[75]].indexOf(OxO81f3[76],fromN)+0;if(toN==-1){toN=document[OxO81f3[75]][OxO81f3[54]];} ;return unescape(document[OxO81f3[75]].substring(fromN,toN));} ;return OxO81f3[4];} ;function setCk(Oxb12){if(Oxb12!=null){exp= new Date();time=365*60*60*24*1000;exp.setTime(exp.getTime()+time);document[OxO81f3[75]]=escape(OxO81f3[77])+OxO81f3[78]+escape(Oxb12)+OxO81f3[79]+OxO81f3[80]+exp.toGMTString();} ;} ;