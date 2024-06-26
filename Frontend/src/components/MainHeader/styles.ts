import styled from 'styled-components';

export const Container = styled.div`
  grid-area: MH;
  background-color: ${(props) => props.theme.colors.main};
  color: ${(prop) => prop.theme.colors.white};
  display: flex;
  flex-direction: column;
  height: 280px;
`;
